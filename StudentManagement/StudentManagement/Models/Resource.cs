using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }

    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ResourceType Type { get; set; }

        public string Url { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
