using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement_
{
    internal class Program
    {
        static void Main()
        {
            using var context = new StudentDbContext();

            var students = context.Students
                .Select(s => new
                {
                    s.Name,
                    Homeworks = s.HomeworkSubmissions.Select(h => new
                    {
                        h.Content,
                        h.ContentType
                    })
                });


            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}");
                foreach (var hw in student.Homeworks)
                {
                    Console.WriteLine($"\tHomework: {hw.Content}, Type: {hw.ContentType}");
                }
            }

            var courses = context.Courses
            .Include(c => c.Resources)
            .OrderBy(c => c.StartDate)
            .ThenByDescending(c => c.EndDate);

            foreach (var course in courses)
            {
                Console.WriteLine($"Course: {course.Name} - {course.Description}");
                foreach (var res in course.Resources)
                {
                    Console.WriteLine($"\tResource: {res.Name} ({res.Type}) - {res.Url}");
                }
            }

            var courses_ = context.Courses
            .Where(c => c.Resources.Count > 5)
            .Select(c => new
            {
                c.Name,
                ResourceCount = c.Resources.Count
            })
            .OrderByDescending(c => c.ResourceCount)
            .ThenByDescending(c => c.Name); // hoặc StartDate nếu cần

            foreach (var course in courses_)
            {
                Console.WriteLine($"Course: {course.Name}, Resources: {course.ResourceCount}");
            }

        }

    }
}

