using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Restriction
    {
        public IEnumerable<Student> Where(List<Student> students)
        {
            return students.Where(x => x.Age > 18);
        }
    }
}
