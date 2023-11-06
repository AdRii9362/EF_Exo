﻿// <auto-generated />
using EF_Exo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Exo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231106135129_Update_MM_OM_Films2")]
    partial class Update_MM_OM_Films2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_Exo.Entities.Acteurs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Acteurs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Nom = "Hammil",
                            Prenom = "Mark"
                        },
                        new
                        {
                            ID = 2,
                            Nom = "Hunnam",
                            Prenom = "Charlie"
                        },
                        new
                        {
                            ID = 3,
                            Nom = "Wood",
                            Prenom = "Elijah"
                        });
                });

            modelBuilder.Entity("EF_Exo.Entities.Films", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnneeSortie")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RealisateursID")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RealisateursID");

                    b.HasIndex("Titre")
                        .IsUnique();

                    b.ToTable("Films");

                    b.HasCheckConstraint("CK_AnneeSortie", "AnneeSortie>1975");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnneeSortie = 1977,
                            Genre = "Science-Fiction",
                            RealisateursID = 1,
                            Titre = "Star Wars : Un nouvel espoir"
                        },
                        new
                        {
                            Id = 2,
                            AnneeSortie = 1980,
                            Genre = "Science-Fiction",
                            RealisateursID = 1,
                            Titre = "Star Wars : L'empire contre-attaque"
                        },
                        new
                        {
                            Id = 3,
                            AnneeSortie = 1983,
                            Genre = "Science-Fiction",
                            RealisateursID = 1,
                            Titre = "Star Wars : Le retour du Jedi"
                        },
                        new
                        {
                            Id = 4,
                            AnneeSortie = 2005,
                            Genre = "Société",
                            RealisateursID = 2,
                            Titre = "Hooligans"
                        },
                        new
                        {
                            Id = 5,
                            AnneeSortie = 2001,
                            Genre = "Heroic-Fantasy",
                            RealisateursID = 3,
                            Titre = "LOTR - La communauté de l'anneau"
                        },
                        new
                        {
                            Id = 6,
                            AnneeSortie = 2002,
                            Genre = "Heroic-Fantasy",
                            RealisateursID = 3,
                            Titre = "LOTR - Les deux tours"
                        },
                        new
                        {
                            Id = 7,
                            AnneeSortie = 2003,
                            Genre = "Heroic-Fantasy",
                            RealisateursID = 3,
                            Titre = "LOTR - Le retour du roi"
                        });
                });

            modelBuilder.Entity("EF_Exo.Entities.MM_Films_Acteurs", b =>
                {
                    b.Property<int>("ActeursID")
                        .HasColumnType("int");

                    b.Property<int>("FilmsID")
                        .HasColumnType("int");

                    b.HasKey("ActeursID", "FilmsID");

                    b.HasIndex("FilmsID");

                    b.ToTable("MM_Films_Acteurs");

                    b.HasData(
                        new
                        {
                            ActeursID = 1,
                            FilmsID = 1
                        },
                        new
                        {
                            ActeursID = 1,
                            FilmsID = 2
                        },
                        new
                        {
                            ActeursID = 1,
                            FilmsID = 3
                        },
                        new
                        {
                            ActeursID = 2,
                            FilmsID = 4
                        },
                        new
                        {
                            ActeursID = 3,
                            FilmsID = 5
                        },
                        new
                        {
                            ActeursID = 3,
                            FilmsID = 6
                        },
                        new
                        {
                            ActeursID = 3,
                            FilmsID = 7
                        });
                });

            modelBuilder.Entity("EF_Exo.Entities.Realisateurs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Realisateurs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Nom = "Lucas",
                            Prenom = "Georges"
                        },
                        new
                        {
                            ID = 2,
                            Nom = "Alexander",
                            Prenom = "Lexi"
                        },
                        new
                        {
                            ID = 3,
                            Nom = "Jackson",
                            Prenom = "Peter"
                        });
                });

            modelBuilder.Entity("EF_Exo.Entities.Films", b =>
                {
                    b.HasOne("EF_Exo.Entities.Realisateurs", "Realisateurs")
                        .WithMany("Films")
                        .HasForeignKey("RealisateursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Realisateurs");
                });

            modelBuilder.Entity("EF_Exo.Entities.MM_Films_Acteurs", b =>
                {
                    b.HasOne("EF_Exo.Entities.Acteurs", "Acteurs")
                        .WithMany("FilmsActeurs")
                        .HasForeignKey("ActeursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Exo.Entities.Films", "Films")
                        .WithMany("ActeursFilms")
                        .HasForeignKey("FilmsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acteurs");

                    b.Navigation("Films");
                });

            modelBuilder.Entity("EF_Exo.Entities.Acteurs", b =>
                {
                    b.Navigation("FilmsActeurs");
                });

            modelBuilder.Entity("EF_Exo.Entities.Films", b =>
                {
                    b.Navigation("ActeursFilms");
                });

            modelBuilder.Entity("EF_Exo.Entities.Realisateurs", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
