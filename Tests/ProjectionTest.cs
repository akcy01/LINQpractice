using LINQ.LINQSubjects;
using LINQ.Tests.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class ProjectionTest
    {
        Projection prj = new Projection();
        public void _Select()
        {
            var students = UntrueStudent.FakeData.Generate(6);
            var result = prj.Select(students);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
