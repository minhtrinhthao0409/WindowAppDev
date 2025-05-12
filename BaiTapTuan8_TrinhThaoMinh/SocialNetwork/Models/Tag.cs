using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork;

namespace SocialNetwork.Models
{
    
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<AlbumTag> AlbumTags { get; set; } = [];
    }

    public class TagAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is not string tag) return false;
            return tag.StartsWith('#') && !tag.Contains(' ') && tag.Length <= 20;
        }
    }
    public static class TagTransformer
    {
        


        public static string Transform(string tag)
        {
            tag = tag.Replace(" ", "");
            if (!tag.StartsWith('#'))
            {
                tag = '#' + tag;
            }
            if (tag.Length > 20)
            {
                tag = tag[..20];
            }
            return tag;
        }
    }

}
