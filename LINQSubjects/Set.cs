using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Set
    {
        /* duplicate elemanları siler. */
        public IEnumerable<int> Distinct(int[] numbers)
        {
            return numbers.Distinct();
        }
        public  IEnumerable<int> Except(List<int> numbers,List<int> numbers2)
        {
            return numbers.Except(numbers2);
        }
        public  IEnumerable<int> Intersect(List<int> numbers, List<int> numbers2)
        {
            return numbers.Intersect(numbers);
        }
        public IEnumerable<int> Union(List<int> numbers, List<int> numbers2)
        {
            return numbers.Union(numbers2);
        }
    }
}
