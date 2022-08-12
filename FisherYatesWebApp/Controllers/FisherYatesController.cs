using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FisherYates.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FisherYatesWebApp.Controllers
{
    public class FisherYatesController : Controller
    {
        private readonly ITokenRandomiser Randomiser;

        public FisherYatesController(ITokenRandomiser randomiser) => this.Randomiser = randomiser;

        /// <summary>
        /// todo: Add the skeleton structure for the solution, and implement unit tests (in the FisherYatesTests project)!
        /// </summary>
        /// <param name="input">List of dasherized elements to shuffle (e.g. "D-B-A-C").</param>
        /// <returns>A "200 OK" HTTP response with a content-type of `text/plain; charset=utf-8`. The content should be the dasherized output of the algorithm, e.g. "C-D-A-B".</returns>
        [Route("/fisheryates")]
        [HttpGet]
        [Produces("text/plain")] // Returns charset=utf-8 by default
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult Randomise(string input)
        {
            if (input == null)
            {
                // Maybe a BadRequest would be more suited but the spec says response is 200 Ok.
                // This probably falls into "Do not worry about server-side validation" but I think its suitably fundemental, that I've done it anyway
                // and it makes it a bit easier to play with during development.
                return Ok();
            }

            // This string processing could be moved out here into a service of its own or some util. We could even do something like putting the delimiter into the settings.
            // Lots of options, but I'm trying not to get bogged down here.
            var Delimiter = "-";
            var inputElements = input.Split(Delimiter);

            var RandomisedElements = Randomiser.RandomiseOrder<string>(inputElements);

            var RandomisedOutput = String.Join(Delimiter, RandomisedElements);

            return Ok(RandomisedOutput);
        }

        // Not quite the single endpoint asked for but saves me some effort developing
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        [Route("/")]
        [HttpGet]
        public IActionResult Redirects() => this.LocalRedirectPermanent("/fisheryates");
    }
}