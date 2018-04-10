using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._11.Fibonacci
{
    /// <summary>
    /// Allows to get Fibonacci numbers.
    /// </summary>
    public class NumberGetter
    {
        /// <summary>
        /// One by one calculates and returns Fibonacci numbers.
        /// </summary>
        /// <returns>Next fibonacci number.</returns>
        public IEnumerable<int> GetNumbers()
        {
            int previous = 0;
            int current = 1;

            yield return current;

            int tmp = 0;
            while(true)
            {
                tmp = previous;
                previous = current;
                current = tmp + current;

                yield return current;
            }
        }
    }
}
