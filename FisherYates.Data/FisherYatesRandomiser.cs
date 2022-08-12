using FisherYates.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FisherYates.Data
{
    public class FisherYatesRandomiser : ITokenRandomiser
    {
        private IRandomNumberGenerator Random { get; }

        public FisherYatesRandomiser(IRandomNumberGenerator random) => this.Random = random;

        public IEnumerable<T> RandomiseOrder<T>(IEnumerable<T> inputs)
        {
            throw new NotImplementedException();
        }
    }
}
