using LINQ.LINQSubjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class PartitioningTest
    {
        Partitioning partitioning = new Partitioning();
        public void _Skip()
        {
            /* verilen index numarasından itibaren gelecek.Biz 2 verdik yani 1235 ve sonrası dönecek. */
            List<int> numbers = new List<int>() { 13, 125, 1235,124,124,562,1523,41234 };
            var result = partitioning.Skip(numbers);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public void _SkipWhile()
        {
            List<string> isimler = new List<string> { "Oğuz", "Kemal", "Sena","Ece", "Jeyan", "Aykut", "İlayda","len"};
            var result = partitioning.SkipWhile(isimler);
            foreach (string names in result)
            {
                Console.WriteLine(names);
            }
        }
    }
}
