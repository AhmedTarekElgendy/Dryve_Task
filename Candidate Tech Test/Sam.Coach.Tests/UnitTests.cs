using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Sam.Coach;
using System.Linq;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        #region Initialize
        LongestRisingSequenceFinder longestRisingSequence = new LongestRisingSequenceFinder();
        #endregion


        [Theory]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 0, -3 }, new[] { 3, 5, 8 })]
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = longestRisingSequence.Find(data.ToList()).Result;

            actual.Should().Equal(expected);
        }

        [Theory]
        [InlineData(new[] { 4, 6, -3, 3, 7, 9 }, new[] { -3, 3, 7, 9 })]
        public async Task Can_Find1(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = longestRisingSequence.Find(data.ToList()).Result;

            actual.Should().Equal(expected);
        }

        [Theory]
        [InlineData(new[] { 9, 6, 4, 5, 2, 0 }, new[] { 4, 5 })]
        public async Task Can_Find2(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = longestRisingSequence.Find(data.ToList()).Result;

            actual.Should().Equal(expected);
        }
    }
}
