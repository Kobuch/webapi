﻿// <auto-generated />
using System;
using Jppapi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jppapi.Migrations
{
    [DbContext(typeof(RozliczenieContext))]
    [Migration("20210611180654_dodanologowanie")]
    partial class dodanologowanie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Jppapi.Models.Logowanie", b =>
                {
                    b.Property<int>("Login_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Zablokowany")
                        .HasColumnType("bit");

                    b.HasKey("Login_id");

                    b.ToTable("Loginy");
                });

            modelBuilder.Entity("Jppapi.Models.Stawka", b =>
                {
                    b.Property<int>("Stawki_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Dniowka_zagraniczna")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Stawka_podstawowa")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Stawki_id");

                    b.ToTable("Stawki");
                });
#pragma warning restore 612, 618
        }
    }
}
