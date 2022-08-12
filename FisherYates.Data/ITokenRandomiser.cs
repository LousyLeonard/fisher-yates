using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYates.Data
{
    public interface ITokenRandomiser
    {
        /// <summary>
        /// Take a list of items and perform a randomise routine on them returning the same list of items in a new order.
        /// </summary>
        /// <typeparam name="T">The type of item to sort and return</typeparam>
        /// <param name="inputs">The list of items to randomise</param>
        /// <returns>A reordered version of the given list</returns>
        public IEnumerable<T> RandomiseOrder<T>(IEnumerable<T> inputs);
    }
}
