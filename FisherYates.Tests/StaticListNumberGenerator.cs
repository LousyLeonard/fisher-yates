using FisherYates.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYates.Tests
{
    class StaticListNumberGenerator : IRandomNumberGenerator
    {
        private readonly IList<int> NumbersToReturn;

        private int selection = 0;

        public StaticListNumberGenerator(IList<int> numbersToReturn) => this.NumbersToReturn = numbersToReturn;

        public int Next(int startRange, int endRange)
        {
            return NumbersToReturn[selection++ % (NumbersToReturn.Count - 1)];
        }
    }
}
