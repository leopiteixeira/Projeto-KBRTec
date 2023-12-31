﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(SolicAdopContext))]
    [Migration("20231103174147_AnimaisMigrations")]
    partial class AnimaisMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .HasColumnType("longtext");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<string>("Porte")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RacaId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("RacaId");

                    b.ToTable("animais");
                });

            modelBuilder.Entity("API.Models.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("especies");
                });

            modelBuilder.Entity("API.Models.Raca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EspecieId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EspecieId");

                    b.ToTable("racas");
                });

            modelBuilder.Entity("API.Models.SolicAdop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DtInsercao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("solics");
                });

            modelBuilder.Entity("API.Models.Animal", b =>
                {
                    b.HasOne("API.Models.Raca", "Raca")
                        .WithMany("Animais")
                        .HasForeignKey("RacaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raca");
                });

            modelBuilder.Entity("API.Models.Raca", b =>
                {
                    b.HasOne("API.Models.Especie", "Especie")
                        .WithMany("Racas")
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especie");
                });

            modelBuilder.Entity("API.Models.SolicAdop", b =>
                {
                    b.HasOne("API.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("API.Models.Especie", b =>
                {
                    b.Navigation("Racas");
                });

            modelBuilder.Entity("API.Models.Raca", b =>
                {
                    b.Navigation("Animais");
                });
#pragma warning restore 612, 618
        }
    }
}
