using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Projection
    {
        public IEnumerable<object> Select(List<Student> students)
        {
            return students.Select(x => new { StudentName = x.Name, Note = x.Note } );
        }
        /* SelectMany birden fazla tablodan veri çekmeye ve bunları istediğimiz formatta birleştirmeye yarar. */
    }
}
