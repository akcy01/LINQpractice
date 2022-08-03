using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Aggregation // Aggregation Türkçesi => Küme
    {
        public double Average(int[] numbers)
        {
            return numbers.Average();
        }
        public double Max(int[] numbers)
        {
            return numbers.Max();
        }
        public double Min(int[] numbers)
        {
            return numbers.Min();
        }
        public double Sum(int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
