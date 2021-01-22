using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sam.Coach
{
    public interface ILongestRisingSequenceFinder {
        Task<List<int>> Find(List<int> numbers);
    }
}