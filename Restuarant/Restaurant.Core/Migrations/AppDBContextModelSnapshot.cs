﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.Core;

namespace Restaurant.Core.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurant.Core.Domain.Cheef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatchPhrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CheefLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Proficiency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cheefs");
                });

            modelBuilder.Entity("Restaurant.Core.Domain.CookingAparature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CookingAparatures");
                });

            modelBuilder.Entity("Restaurant.Core.Domain.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Complexity")
                        .HasColumnType("int");

                    b.Property<int?>("CookingApparatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CookingApparatusId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("Restaurant.Core.Domain.Food", b =>
                {
                    b.HasOne("Restaurant.Core.Domain.CookingAparature", "CookingApparatus")
                        .WithMany()
                        .HasForeignKey("CookingApparatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
