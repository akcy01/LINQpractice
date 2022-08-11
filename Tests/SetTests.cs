using LINQ.LINQSubjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class SetTests
    {
        Set st = new Set();
        public void _Distinct()
        {
            int [] sayilar = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 6, 6, 6, 7, 7, 7, 8, 9, 9, 9, 1, 1 };
            var result = st.Distinct(sayilar);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        /* Karşılaştırıldığı collectionda tekrarlayan elemanları eleyen methodtur. */
        public void _Except()
        {
            List<int> sayilar = new List<int> { 1, 2, 3 };
            List<int> sayilar2 = new List<int> { 3, 4, 5};
            var result = st.Except(sayilar, sayilar2);
            foreach (var item in result)
            {
                Console.WriteLine(item); //1 ve 2 gelecek 3 atılacak.
            }
        }
        public void _Intersect()
        {
            List<int> sayilar = new List<int> { 1, 2, 3 };
            List<int> sayilar2 = new List<int> { 3, 4, 5};
            var result = st.Intersect(sayilar, sayilar2);
            foreach (var item in result)
            {
                Console.WriteLine(item); // 3 gelecek
            }
        }
        /* İki koleksiyonu birleştirir ve distinct hale getirir. */
        public void _Union()
        {
            List<int> sayilar = new List<int> { 1, 2, 3 };
            List<int> sayilar2 = new List<int> { 3, 4, 5 };
            var result = st.Union(sayilar, sayilar2);
            foreach (var item in result)
            {
                Console.WriteLine(item); // 1,2,3,4,5 gelecek
            }
        }
    }
}
