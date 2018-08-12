using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrderFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var multipleOfTwo = numbers.SingleElseException(n => n % 2 == 0, count => new Exception("MESSAGE" + count + "COOL"));
        }
    }

    static class MyEnumerableExtensions
    {
        public static int SingleElseException(this IEnumerable<int> numbers, Func<int, bool> predicate, Func<int, Exception> exceptionFactory)
        {
            var matchedCount = 0;
            var matchedNumber = 0;

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    matchedCount++;
                    matchedNumber = number;
                }
            }

            if (matchedCount == 1)
            {
                return matchedNumber;
            }

            throw exceptionFactory(matchedCount);
        }
    }
}
