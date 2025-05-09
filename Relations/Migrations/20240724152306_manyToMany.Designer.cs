﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Relations;

#nullable disable

namespace Relations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240724152306_manyToMany")]
    partial class manyToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Relations.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Relations.PostTag", b =>
                {
                    b.Property<string>("postId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AddedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("postId", "tagId");

                    b.HasIndex("tagId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("Relations.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Relations.PostTag", b =>
                {
                    b.HasOne("Relations.Post", "post")
                        .WithMany("postTags")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Relations.Tag", "Tag")
                        .WithMany("postTags")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("post");
                });

            modelBuilder.Entity("Relations.Post", b =>
                {
                    b.Navigation("postTags");
                });

            modelBuilder.Entity("Relations.Tag", b =>
                {
                    b.Navigation("postTags");
                });
#pragma warning restore 612, 618
        }
    }
}
