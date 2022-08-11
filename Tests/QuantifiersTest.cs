using LINQ.LINQSubjects;
using LINQ.Tests.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class QuantifiersTest
    {
        Quantifiers quan = new Quantifiers();
        public void _All()
        {
            var students = UntrueStudent.FakeData.Generate(6);
            var result = quan.All(students);
            Console.WriteLine(result);
        }
        public void _Any()
        {
            var students = UntrueStudent.FakeData.Generate(6);
            var result = quan.Any(students);
            Console.WriteLine(result);
        }
        public void _Contains()
        {
            var students = UntrueStudent.FakeData.Generate(6);
            var result = quan.Contains(students);
            Console.WriteLine(result);
        }
    }
}
