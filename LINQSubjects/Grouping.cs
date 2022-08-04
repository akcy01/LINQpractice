using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Grouping
    {
        public IEnumerable<IGrouping<bool,Student>> GroupBy(List<Student> students)
        {
            return students.GroupBy(x => x.Category == "Basketball" );
        }
    }
}
