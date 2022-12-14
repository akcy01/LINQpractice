using LINQ.LINQSubjects;
using LINQ.Models;
using LINQ.Tests.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class OrderingTest
    {
        Ordering ord = new Ordering();
        public void _OrderBy()
        {
            var numbers = new List<int>() { 123, 124, 12, 54, 14, 51, 0 };
            var result = ord.OrderBy(numbers);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void _OrderByDescending()
        {
            var numbers = new List<int>() {1241,12351,6123,3456,8541,13,6,-31 };
            var result = ord.OrderByDescending(numbers);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void _Reverse()
        {
            /* Önce listenin normal halini yazdırdık.Sonra reverse edilmiş halini.Reverse listei tersine döndürme işlemini gerçekleştirir. */
            var students = UntrueStudent.FakeData.Generate(10);
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Age);
            }
            var result = ord.Reverse(students);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
            }
        }

    }
}
