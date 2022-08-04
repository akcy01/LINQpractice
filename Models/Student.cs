using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Category { get; set; }
        public int Age { get; set; }
        public decimal Note { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
