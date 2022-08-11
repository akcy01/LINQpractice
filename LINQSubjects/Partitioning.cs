using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Partitioning
    {
        public IEnumerable<int> Skip(List<int> numbers)
        {
           return numbers.Skip(2);
        }
        public IEnumerable<string> SkipWhile(List<string> isimler)
        {
            return isimler.SkipWhile(x => x.Length == 3); /* Length'i 3 olan elemanları atlattık. */
        }
    }
}
