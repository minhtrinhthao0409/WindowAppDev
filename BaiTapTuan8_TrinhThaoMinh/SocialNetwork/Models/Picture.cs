using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Caption { get; set; } = null!;
        public string Path { get; set; } = null!;

        public ICollection<Album> Albums { get; set; } = [];
    }

}
