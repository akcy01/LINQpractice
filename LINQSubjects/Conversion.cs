using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQSubjects
{
    /* OfType => Elemanlar arasından belirtilen type’a göre filtreleme yapar. */
    /* ToDictionary => Collection’u Dictionary’e çeviren extensiondur. */
    /* ToLookUp => Collection’u key bazlı gruplayan extensiondur. */
    public class Conversion // Conversion türkçesi => Dönüştürmek
    {
       public IEnumerable<object> OfType(List<object> objects)
        {
            return objects.OfType<string>(); //String tipindeki değişkenleri alıcaz.
        }
       public Dictionary<Student,string> ToDictionary(List<Student> students)
        {
            return students.ToDictionary(x => x, v => v.Note > 50  ? "Geçti" : "Kaldı");   
        }
        public IEnumerable<Student> ToLookUp(List<Student> students)
        {
            return students.ToLookup(c=> c.Category)["Basketball"];
            /* Sadece basketball key'ine göre verileri döndürdüm. */
        }
    }
}
