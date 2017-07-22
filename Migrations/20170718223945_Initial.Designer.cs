using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using codesnippet.Models;

namespace codesnippet.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170718223945_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("codesnippet.Models.Snippet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodeSnippet")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(140);

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(140);

                    b.HasKey("ID");

                    b.ToTable("Snippets");
                });
        }
    }
}
