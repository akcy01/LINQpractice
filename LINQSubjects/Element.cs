using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* First => Collectiondaki ilk elemanı bulan extension methodtur. Eğer collectionda aranan değer bulunamadıysa InvalidOperationException fırlatır. */
namespace LINQ.LINQSubjects
{
    public class Element
    {
        public Student First(List<Student> students,int id)
        {
            return students.First(p => p.Id == id);    
        }
        public Student FirstOrDefault(List<Student> students,int id)
        {
            return students.FirstOrDefault(p => p.Id == id);
        }
        public Student Last(List<Student> students,string category)
        {
            return students.Last(p => p.Category == category);
        }
        public Student LastOrDefault(List<Student> students, string category)
        {
            return students.LastOrDefault(p => p.Category == category);
        }
        public Student Single(List<Student> students,string category)
        {
            return students.Single(p => p.Category == category);
        }
        public Student SingleOrDefault(List<Student> students,string category)
        {
            return students.SingleOrDefault(p => p.Category == category );
        }

    }
}
