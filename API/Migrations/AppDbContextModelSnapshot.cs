﻿// <auto-generated />
using API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("API.Domain.Models.Board", b =>
            {
                b.Property<int>("BoardId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("character varying(30)")
                    .HasMaxLength(30);

                b.HasKey("BoardId");

                b.ToTable("Boards");

                b.HasData(
                    new
                    {
                        BoardId = 1,
                        Name = "Tasks"
                    });
            });

            modelBuilder.Entity("API.Domain.Models.Task", b =>
            {
                b.Property<int>("TaskId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer")
                    .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                b.Property<int>("BoardId")
                    .HasColumnType("integer");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("character varying(30)")
                    .HasMaxLength(30);

                b.Property<bool>("IsCompleted")
                    .HasColumnType("boolean");

                b.Property<byte>("Priority")
                    .HasColumnType("smallint");

                b.HasKey("TaskId");

                b.HasIndex("BoardId");

                b.ToTable("Tasks");

                b.HasData(
                    new
                    {
                        TaskId = 1,
                        BoardId = 1,
                        Description = "Hello World",
                        IsCompleted = false,
                        Priority = (byte)1
                    });
            });

            modelBuilder.Entity("API.Domain.Models.Task", b =>
            {
                b.HasOne("API.Domain.Models.Board", "Board")
                    .WithMany("Tasks")
                    .HasForeignKey("BoardId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}
