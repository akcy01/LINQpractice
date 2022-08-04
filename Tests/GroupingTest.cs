using LINQ.LINQSubjects;
using LINQ.Tests.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class GroupingTest
    {
        Grouping group = new Grouping();
        public void _GroupBy()
        {
            var students = UntrueStudent.FakeData.Generate(20);
            var result = group.GroupBy(students);
            var allBasketball = result.Where(x => x.Key).SelectMany(x => x);
            var allBaseball = result.Where(x => !x.Key).SelectMany(x => x);
            foreach (var item in allBasketball)
            {
                Console.WriteLine("Basketball'a göre gruplandırılmış öğrencinin Adı => " + item.Name);
                Console.WriteLine("Basketball'a göre gruplandırılmış öğrencinin yaşı => " + item.Age);
                Console.WriteLine("Basketball'a göre gruplandırılmış öğrencilerin Notu => " + item.Note);
            }
            foreach (var item in allBaseball)
            {
                Console.WriteLine("Baseball'a göre gruplandırılmış öğrencinin Adı => " + item.Name);
                Console.WriteLine("Baseball'a göre gruplandırılmış öğrencinin yaşı => " + item.Age);
                Console.WriteLine("Baseball'a göre gruplandırılmış öğrencilerin Notu => " + item.Note);
            }
        }
    }
}
