﻿// <auto-generated />
using LojaDeCinema.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LojaDeCinema.Migrations
{
    [DbContext(typeof(LojaDeCinemaDBContex))]
    partial class LojaDeCinemaDBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LojaDeCinema.Modelos.Bilhete", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("NomeFilme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PercentagemCorteStudio")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Bilhetes");
                });

            modelBuilder.Entity("LojaDeCinema.Modelos.ItemAlimentar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("itemsAlimentar");
                });
#pragma warning restore 612, 618
        }
    }
}