using LINQ.LINQSubjects;
using LINQ.Tests.FakeData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class ConversionTest
    {
        Conversion con = new Conversion();
        public void _OfType()
        {
            List<object> objects = new List<object>();
            objects.Add("Oğuz");
            objects.Add("Kemal");
            objects.Add(13);
            objects.Add(19);
            objects.Add(0);
            var result = con.OfType(objects);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void _ToDictionary()
        {
            var students = UntrueStudent.FakeData.Generate(5);
            var result = con.ToDictionary(students);

            foreach (var item in result)
            {
                Console.WriteLine(item.Value);
            }
        }

    }
}
