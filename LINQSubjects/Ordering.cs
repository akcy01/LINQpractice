using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Ordering
    {
        public IEnumerable<int> OrderBy(List<int> numbers)
        {
            /* OrderBy küçükten büyüğe sıralar. */
            return numbers.OrderBy(x => x).ToList();
        }
        public IEnumerable<int> OrderByDescending(List<int> numbers)
        {
            /* Büyükten küçüğe sıralar. */
            return numbers.OrderByDescending(x => x).ToList();
        }
        public IEnumerable<Student> Reverse(List<Student> students)
        {
            /* Koleksiyonu tersine döndürür. */
            students.Reverse();
            return students;
        }
    }
}
