using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    /* OfType => Elemanlar arasından belirtilen type’a göre filtreleme yapar. */
    public class Conversion // Conversion türkçesi => Dönüştürmek
    {
       public IEnumerable<object> OfType(List<object> objects)
        {
            return objects.OfType<string>(); //String tipindeki değişkenleri alıcaz.
        }
       public Dictionary<Student,string> ToDictionary(List<Student> students)
        {
            return students.ToDictionary(x => x, v => v.Id > 2  ? "New" : "Old");   
        }

    }
}
