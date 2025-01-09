﻿// <auto-generated />
using System;
using ErecrTest.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ErecrTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250107220206_addRecruteur")]
    partial class addRecruteur
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ErecrTest.Models.Candidature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePostulation")
                        .HasColumnType("datetime2");

                    b.Property<int>("OffreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OffreId");

                    b.ToTable("Candidature");
                });

            modelBuilder.Entity("ErecrTest.Models.Offre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Poste")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecruteurId")
                        .HasColumnType("int");

                    b.Property<decimal>("Remuneration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Secteur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeContrat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecruteurId");

                    b.ToTable("Offres");
                });

            modelBuilder.Entity("ErecrTest.Models.Recruteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recruteurs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "fatiezzahra@gmail.com",
                            Nom = "venus",
                            Tel = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mrsomebody@gmail.com",
                            Nom = "Mr Somebody",
                            Tel = "987654321"
                        });
                });

            modelBuilder.Entity("ErecrTest.Models.Candidature", b =>
                {
                    b.HasOne("ErecrTest.Models.Offre", null)
                        .WithMany("Candidatures")
                        .HasForeignKey("OffreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ErecrTest.Models.Offre", b =>
                {
                    b.HasOne("ErecrTest.Models.Recruteur", "Recruteur")
                        .WithMany("Offres")
                        .HasForeignKey("RecruteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recruteur");
                });

            modelBuilder.Entity("ErecrTest.Models.Offre", b =>
                {
                    b.Navigation("Candidatures");
                });

            modelBuilder.Entity("ErecrTest.Models.Recruteur", b =>
                {
                    b.Navigation("Offres");
                });
#pragma warning restore 612, 618
        }
    }
}
