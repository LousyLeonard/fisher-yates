using FisherYates.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FisherYates.Tests
{
    public class FisherYatesRandomiserShould
    {
        [Fact]
        public void ReturnAListWithTheSameValues()
        {
            var Sut = new FisherYatesRandomiser(new SystemRandomNumberGenerator());

            var TestValues = new List<string>() { "a", "b", "c" };

            var RandomisedElements = Sut.RandomiseOrder<String>(TestValues);

            var ExpectedElements = TestValues.OrderBy(e => e);
            var NormalisedElements = RandomisedElements.OrderBy(e => e);

            Assert.Equal(ExpectedElements, NormalisedElements);
        }

        [Fact]
        public void ShuffleAsExpected()
        {
            var Sut = new FisherYatesRandomiser(new StaticListNumberGenerator(new List<int>() { 3, 2, 1 }));

            var TestValues = new List<string>() { "a", "b", "c" };

            /// Backwards selection goes 
            /// 3 = c to the back of the list (c)
            /// 2 = b to the back of the list (c, b)
            /// 1 = a to the back of the list (c, b, a)
            var ExpectedValues = new List<string>() { "c", "b", "a" };

            var RandomisedElements = Sut.RandomiseOrder<String>(TestValues);

            Assert.NotEqual(ExpectedValues, RandomisedElements);
        }
    }
}
