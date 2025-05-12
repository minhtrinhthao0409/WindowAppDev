using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork;

namespace SocialNetwork.Models
{
    public class Friendship
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int FriendId { get; set; }
        public User Friend { get; set; } = null!;
    }

}
