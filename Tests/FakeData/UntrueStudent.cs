using Bogus;
using LINQ.Models;

namespace LINQ.Tests.FakeData
{
    public static class UntrueStudent
    {
        public static Faker<Student> FakeData
        {
            get
            {
                var studentId = 1;
                return new Faker<Student>()
                    .RuleFor(s => s.Name, x => x.Name.FirstName())
                    .RuleFor(s => s.Note, x => x.Random.Number(0, 100))
                    .RuleFor(s => s.Id, x => studentId++)
                    .RuleFor(s => s.Age, x => x.Random.Number(12, 22))
                    .RuleFor(s => s.Category, x => studentId % 2 == 0 ? "Basketball" : "Baseball");
            }
        }

    }
}
