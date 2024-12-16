using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCore;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasMany(p => p.tags)
                .WithMany(p => p.posts)
                .UsingEntity(j => j.ToTable("PostTags"));
             

        }
        public DbSet<Blog> Employees { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Category> categories { get; set; }
    }
    public class Blog
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
    public class Tag
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required ICollection<Post> posts { get; set; }
    }
    public class Post
    {
        public int Id { get; set; }
        public required string content { get; set; }
        public required string Title { get; set; }
        public required ICollection<Tag> tags { get; set; }

    }
}
