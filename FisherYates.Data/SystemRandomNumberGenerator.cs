using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYates.Data
{
    public class SystemRandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random Rnd = new();

        public SystemRandomNumberGenerator() {}

        public int Next(int startRange, int endRange)
        {
            return Rnd.Next(startRange, endRange);
        }
    }
}
