using LINQ.LINQSubjects;
using LINQ.Models;
using LINQ.Tests.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    public class ElementTest
    {
        Element elm = new Element();
        public void _First()
        {
            /* Verdiğin Id değerindeki kullanıcıyı getirecek.Koleksiyondan sadece 1 veri döndürecek. */
            var students = UntrueStudent.FakeData.Generate(10);
            var result = elm.First(students,3);
            Console.WriteLine("3 Id numaralı öğrencinin ismi => " + result.Name);
            Console.WriteLine("3 Id numaralı öğrencinin yaşı => " + result.Age);
            Console.WriteLine("3 Id numaralı öğrencinin notu => " + result.Note);
        }
        public void _FirstOrDefault()
        {
            /* Verdiğin Id değerindeki kullanıcıyı getirecek.Eğer boşsa eleman yoksa default type döndürür.Eğer Id vermezsen otomatik olarak koleksiyondaki ilk veriyi getirir.Biz 4 numaralı Id'yi koyduğumuz için onun verileri gelecek. */
            var students = UntrueStudent.FakeData.Generate(10);
            var result = elm.FirstOrDefault(students,4);
            Console.WriteLine("4 Id numaralı öğrencinin ismi => " + result.Name);
            Console.WriteLine("4 Id numaralı öğrencinin yaşı => " + result.Age);
            Console.WriteLine("4 Id numaralı öğrencinin notu => " + result.Note);
        }
        public void _Last()
        {
            /* Koleksiyondaki öğrencilerin,kategorisi basketball olanlardan sonuncusu gelecek.Last bu işi yapar koleksiyondaki son veriyi getirir. */
            var students = UntrueStudent.FakeData.Generate(10);
            var result = elm.Last(students, "Basketball");
            Console.WriteLine("Kategorisi Basketball olan son öğrencinin adı => " + result.Name);
            Console.WriteLine("Kategorisi Basketball olan son öğrencinin yaşı => " + result.Age);
            Console.WriteLine("Kategorisi Basketball olan son öğrencinin notu => " + result.Note);
        }
        public void _LastOrDefault()
        {
            /* Koleksiyondaki öğrencilerin,kategorisi baseball olanlardan sonuncusu gelecek.Gelmezse default type döndürür. */
            var students = UntrueStudent.FakeData.Generate(10);
            var result = elm.LastOrDefault(students, "Baseball");
            Console.WriteLine("Kategorisi Baseball olan son öğrencinin adı => " + result.Name);
            Console.WriteLine("Kategorisi Baseball olan son öğrencinin yaşı => " + result.Age);
            Console.WriteLine("Kategorisi Baseball olan son öğrencinin notu => " + result.Note);
        }
        public void _Single()
        {
            /* Collectionda yer alan tek bir uniqe elemanı bulan extension methodtur. Eğer collectionda aranan eleman bulunamadıysa veya birden daha fazla sayıda varsa exception döner. */
            var students = UntrueStudent.FakeData.Generate(2);
            var result = elm.Single(students, "Basketball");
            Console.WriteLine("Kategorisi Basketball olan tek öğrencinin adı => " + result.Name);
            Console.WriteLine("Kategorisi Basketball olan tek öğrencinin yaşı => " + result.Age);
            Console.WriteLine("Kategorisi Basketball olan tek öğrencinin notu => " + result.Note);
        }
        public void _SingleOrDefault()
        {
            /* Collection'da yer alan tek (unique) elemanı getirir.Getirmezse default type döner.Eğer benzersiz değilse hata fırlatır.Mesela generate'yi 2 den fazla yaparsak hata fırlatma olasılığı yüksek.Çünkü birden fazla kategorisi basketball olan öğrenci olabilir. */
            var students = UntrueStudent.FakeData.Generate(2);
            var result = elm.SingleOrDefault(students, "Basketball");
            Console.WriteLine("Kategorisi Basketball olan tek(unique) öğrencinin adı => " + result.Name);
            Console.WriteLine("Kategorisi Basketball olan tek(unique) öğrencinin yaşı => " + result.Age);
            Console.WriteLine("Kategorisi Basketball olan tek(unique) öğrencinin notu => " + result.Note);
        }
    }
}
