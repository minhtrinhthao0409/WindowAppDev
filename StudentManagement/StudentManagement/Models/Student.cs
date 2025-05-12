using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Students
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime? Birthday { get; set; }

        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
    }
}
