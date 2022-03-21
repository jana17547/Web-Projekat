﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Web.Migrations
{
    [DbContext(typeof(AutoSkolaContext))]
    [Migration("20211225225128_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Models.Kandidat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DatumUpisa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Staus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Kandidat");
                });

            modelBuilder.Entity("Models.Kategorija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Cena")
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<string>("GodineStarosti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("ID");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("Models.Polaganje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DatumPolaganja")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IDKandidata")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Kategorija")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("Poeni")
                        .HasColumnType("int");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Polaganja");
                });

            modelBuilder.Entity("Models.Spoj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KandidatID")
                        .HasColumnType("int");

                    b.Property<int?>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<int?>("PolaganjeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KandidatID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("PolaganjeID");

                    b.ToTable("Spojevi");
                });

            modelBuilder.Entity("Models.Spoj", b =>
                {
                    b.HasOne("Models.Kandidat", "Kandidat")
                        .WithMany()
                        .HasForeignKey("KandidatID");

                    b.HasOne("Models.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID");

                    b.HasOne("Models.Polaganje", "Polaganje")
                        .WithMany("Kandidati")
                        .HasForeignKey("PolaganjeID");

                    b.Navigation("Kandidat");

                    b.Navigation("Kategorija");

                    b.Navigation("Polaganje");
                });

            modelBuilder.Entity("Models.Polaganje", b =>
                {
                    b.Navigation("Kandidati");
                });
#pragma warning restore 612, 618
        }
    }
}