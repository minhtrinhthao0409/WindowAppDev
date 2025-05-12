using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Homework
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public DateTime SubmissionDate { get; set; }

        public int StudentId { get; set; }
        public Students Student { get; set; } = null!;
    }
}
