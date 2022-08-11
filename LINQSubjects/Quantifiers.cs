using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    public class Quantifiers
    {
        /* Collection içerisindeki her elemanın verilen önermeyi sağlamasını kontrol eder. */
        public bool All(List<Student> students)
        {
            /* Eğer notların hepsi 0'dan büyükse true dönecek.*/
            return students.All(x => x.Note > 0);
        }
        /* Collection içerisindeki herhangi bir elemanın verilen önermeyi sağlamasını kontrol eder. */
        public bool Any(List<Student> students)
        {
            return students.Any(x => x.Note < 30);
        }
        /* Collection içerisindeki herhangi bir elemanın verilen contains içeriğini sağlamasını kontrol eder. */
        public bool Contains(List<Student> students)
        {
            var studentName = students.First().Name;
            return studentName.Contains(students.First().Name);
        }
    }
}
