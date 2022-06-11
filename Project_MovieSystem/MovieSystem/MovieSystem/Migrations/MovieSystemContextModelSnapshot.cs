﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieSystem.Models;

namespace MovieSystem.Migrations
{
    [DbContext(typeof(MovieSystemContext))]
    partial class MovieSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieSystem.Models.Actor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actor_Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("DOB")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("MovieSystem.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actors")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("DateRelease")
                        .IsRequired();

                    b.Property<string>("Movie_Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Plot")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Poster");

                    b.Property<string>("Producers")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieSystem.Models.Producer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("DOB")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Producer_Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("Producer");
                });
#pragma warning restore 612, 618
        }
    }
}
