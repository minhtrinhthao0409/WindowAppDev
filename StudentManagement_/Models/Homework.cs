using StudentManagement_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_
{
    public class Homework
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public DateTime SubmissionDate { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
