using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string BackgroundColor { get; set; } = null!;
        public bool IsPublic { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; } = null!;

        public ICollection<Picture> Pictures { get; set; } = [];
        public ICollection<AlbumTag> AlbumTags { get; set; } = [];
        public ICollection<AlbumShare> SharedWith { get; set; } = [];
    }

}
