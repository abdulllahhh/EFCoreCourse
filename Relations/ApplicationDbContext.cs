using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Relations.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Relations.Models;

namespace Relations
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured )
            {
                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Relations;")
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Relations;",
                o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)                    
                    );
                //optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Relations;");
                // optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity<PostTag>(
                    j => j
                    .HasOne(pt => pt.Tag)
                    .WithMany(t => t.postTags)
                    .HasForeignKey(pt => pt.tagId),

                    j => j
                    .HasOne(pt => pt.post)
                    .WithMany(p => p.postTags)
                    .HasForeignKey(pt => pt.postId),

                    j =>
                    {
                        j.Property(pt => pt.AddedOn).HasDefaultValueSql("GETDATE()");
                        j.HasKey(t => new { t.postId, t.tagId });
                    }
                );
            modelBuilder.Entity<Nationality>()
                .HasData(new Nationality { NationalityId = 1000, Name = "Russian" }
                    , new Nationality { NationalityId = 2000, Name = "Colombian" }
                    , new Nationality { NationalityId = 3000, Name = "American" }
                    , new Nationality { NationalityId = 4000, Name = "britsh" }
                    , new Nationality { NationalityId = 5000, Name = "Egyptian" }
                );
            modelBuilder.Entity<Book>()
                .HasData(new Book { BookId = 1, Name = "", Price = 20, AuthorId = 2 }
                , new Book { BookId = 2, Name = "head first dp", Price = 20, AuthorId = 3 }
                , new Book { BookId = 3, Name = "head first ooa&d", Price = 20, AuthorId = 4 }
                , new Book { BookId = 4, Name = "grokking algorithm", Price = 20, AuthorId = 5 }
                , new Book { BookId = 5, Name = "c# in a nutshell", Price = 20, AuthorId = 2 }
                , new Book { BookId = 6, Name = "pro c# .net development", Price = 20, AuthorId = 3 }

                );
            modelBuilder.Entity<Author>()
                .HasData(
                new Author { AuthorId = 1, Name = "Gabrial jesus", NationalityId = 2000 }
                , new Author { AuthorId = 2, Name = "Abdullah Ibrahim", NationalityId = 3000 }
                , new Author { AuthorId = 3, Name = "cr7", NationalityId = 2000 }
                , new Author { AuthorId = 4, Name = "Messi", NationalityId = 5000 }
                , new Author { AuthorId = 5, Name = "abo treka", NationalityId = 1000 }

                );

            modelBuilder.Entity<PostTag>()
                .Property(p => p.AddedOn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(p => p.orderNumber)
                .HasColumnType("int")
                .HasDefaultValueSql("NEXT VALUE FOR orderNumber")
                .IsRequired();

            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.tagId, pt.postId });

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.post)
                .WithMany(pt => pt.postTags)
                .HasForeignKey(pt => pt.postId);

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(pt => pt.postTags)
                .HasForeignKey(pt => pt.tagId);

            /* modelBuilder.Entity<person>()
                 .HasIndex(pt => new { pt.firstname , pt.lastname})
                 .HasFilter("index_name");*/
            modelBuilder.Entity<Post>()
                .HasOne(pt => pt.Tag)
                .WithMany()
                .HasForeignKey(pt => pt.TagId);

            modelBuilder.HasSequence<int>("orderNumber")
                .StartsAt(1000)
                .IncrementsBy(5);

            modelBuilder.Entity<Order>()
                .Property(o => o.orderNumber)
                .HasDefaultValueSql("NEXT VALUE FOR orderNumber");

            modelBuilder.Entity<Order>()
                .HasKey(o => o.OrderId);

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderId)
                .ValueGeneratedOnAdd();


            modelBuilder.Entity<Post>()
                .HasData(new Post { Content = "very much content", Id = "10", Title = "title test" });

            modelBuilder.Entity<Tag>()
                .HasData(new Tag { Id = "1" });

            modelBuilder.Entity<PostTag>()
                .HasData(new PostTag { tagId = "1", postId = "10" });

            // Seeding data for Posts and Tags
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = "9", Title = "First Post", Content = "Content of first post" },
                new Post { Id = "2", Title = "Second Post", Content = "Content of second post" }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = "25" },
                new Tag { Id = "2" }
            );

            modelBuilder.Entity<PostTag>().HasData(
                new PostTag { postId = "9", tagId = "25", AddedOn = DateTime.Now },
                new PostTag { postId = "9", tagId = "2", AddedOn = DateTime.Now },
                new PostTag { postId = "2", tagId = "25", AddedOn = DateTime.Now }
            );
            modelBuilder.Entity<Author>()
                .HasMany(b => b.books)
                .WithOne(b => b.Author);


            modelBuilder.Entity<Author>()
                .HasOne(n => n.nationality)
                .WithMany(a => a.authors);

            modelBuilder.Entity<BookDTO>(e => e.HasNoKey().ToView(null));
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<MOCK_DATA> MOCK_DATAs { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<BookDTO> BookDTO { get; set; }
    }   
} 
