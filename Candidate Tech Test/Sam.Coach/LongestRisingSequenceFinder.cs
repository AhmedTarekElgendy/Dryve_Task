using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sam.Coach
{
    public class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        #region Initialize
        List<int> allLequesncesLength = new List<int>();
        List<int> allLequesncesStartIndx = new List<int>();
        List<int> allLequesncesEndIndx = new List<int>();
        List<int> longestSeq = new List<int>();
        List<int> sequence = new List<int>();
        IEnumerable<int> result;
        int start = 0;
        bool isStart = false;
        #endregion

        public Task<List<int>> Find(List<int> numbers)
        {
            sequence = numbers.ToList();
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] < sequence[i + 1])
                {
                    if (!isStart)
                    {
                        start = i;
                        isStart = true;
                    }
                }
                else
                {
                    if (isStart)
                    {
                        allLequesncesStartIndx.Add(start);
                        allLequesncesEndIndx.Add(i);
                        allLequesncesLength.Add(i - start);
                        start = 0;
                        isStart = false;
                    }
                }

                if ((i == (sequence.Count - 2)) && isStart)
                {
                    allLequesncesStartIndx.Add(start);
                    allLequesncesEndIndx.Add(i+1);
                    allLequesncesLength.Add((i+1) - start);
                }

            }
            var ind = allLequesncesLength.IndexOf(allLequesncesLength.Max());
            for (int i = allLequesncesStartIndx[ind]; i <= allLequesncesEndIndx[ind]; i++)
            {
                longestSeq.Add(sequence[i]);
            }
            return Task.FromResult(longestSeq);
        }
    }
}
