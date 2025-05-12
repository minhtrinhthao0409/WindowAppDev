using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork;

namespace SocialNetwork.Models
{
    public class User
    {
        public int Id { get; set; }

        
        [Required, MinLength(4), MaxLength(30)]
        public required string Username { get; set; }

        [Required, MinLength(6), MaxLength(50)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+<>?]).+$")]
        public required string Password { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        public byte[]? ProfilePicture { get; set; } 

        public DateTime RegisteredOn { get; set; }
        public DateTime LastTimeLoggedIn { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        public bool IsDeleted { get; set; }

        // Relationships
        public ICollection<Friendship> FriendsAdded { get; set; } = [];
        public ICollection<Friendship> FriendsOf { get; set; } = [];
        public ICollection<Album> Albums { get; set; } = [];
        public ICollection<AlbumShare> AlbumShares { get; set; } = [];
    }

}
