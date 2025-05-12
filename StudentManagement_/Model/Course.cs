using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;


        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new List<Homework>();
    }
}
