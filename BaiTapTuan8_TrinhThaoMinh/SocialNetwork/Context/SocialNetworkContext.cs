using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models;
using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SocialNetwork.Context
{
    public class SocialNetworkContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<AlbumTag> AlbumTags { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<AlbumShare> AlbumShares { get; set; }

        public string DbPath { get; }

        public SocialNetworkContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "socialnetwork.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friendship>()
                .HasKey(f => new { f.UserId, f.FriendId });

            modelBuilder.Entity<AlbumTag>()
                .HasKey(at => new { at.AlbumId, at.TagId });

            modelBuilder.Entity<AlbumShare>()
                .HasKey(a => new { a.AlbumId, a.UserId });

            modelBuilder.Entity<Picture>()
                .HasMany(p => p.Albums)
                .WithMany(a => a.Pictures);
        }
    }
}
