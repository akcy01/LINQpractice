using LINQ.LINQSubjects;
using LINQ.Tests.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class RestrictionTests
    {
        Restriction rstrct = new Restriction();
        public void _RestrictionTest()
        {
            var students = UntrueStudent.FakeData.Generate(6);
            var result = rstrct.Where(students);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
