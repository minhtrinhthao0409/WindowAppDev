using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class AlbumShare
    {
        public int AlbumId { get; set; }
        public Album Album { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public string Role { get; set; } = null!; // "Owner" | "Viewer"
    }

}
