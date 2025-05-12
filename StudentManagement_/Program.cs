using Microsoft.EntityFrameworkCore;
namespace StudentManagement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new StudentDbContext();

            Console.WriteLine($"Database path: {db.DbPath}.");

        }
    }
}
