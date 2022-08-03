using LINQ.LINQSubjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class AggregattionTest
    {
        Aggregation _aggregation = new Aggregation();
        //private readonly Aggregation _aggregation;
        //public AggregattionTest()
        //{
        //    _aggregation = new Aggregation();
        //}
        public void _Average()
        {
            int[] numbers = new int[] { 30, 40, 50, 60 };
            var result = _aggregation.Average(numbers);
            Console.WriteLine(result);
        }
        public void _Max()
        {
            int[] numbers = new int[] {20, 30, 50, 60,120};
            var result = _aggregation.Max(numbers);
            Console.WriteLine(result);
        }
        public void _Min()
        {
            int[] numbers = new int[] { 20, 30, 50, 60, 120 };
            var result = _aggregation.Min(numbers);
            Console.WriteLine(result);
        }
        public void _Sum()
        {
            int[] numbers = new int[] { 20, 30, 50, 60, 120 };
            var result = _aggregation.Sum(numbers);
            Console.WriteLine(result);
        }
    }
}
