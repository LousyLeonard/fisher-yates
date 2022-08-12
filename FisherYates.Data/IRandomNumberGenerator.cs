using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYates.Data
{
    public interface IRandomNumberGenerator
    {
        public int Next(int startRange, int endRange);
    }
}
