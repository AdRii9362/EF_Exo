using EF_Exo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Configs
{
    // Configuration de la classe intermédiaire MM_Films_Acteurs pour la relation Many-to-Many entre Acteurs et Films
    public class MM_Films_Acteurs_Config : IEntityTypeConfiguration<MM_Films_Acteurs>
    {
        public void Configure(EntityTypeBuilder<MM_Films_Acteurs> builder)
        {
            // Définition de la clé primaire composite pour la relation Many-to-Many entre Acteurs et Films
            builder.HasKey(fa => new { fa.ActeursID, fa.FilmsID }); // MANY 2 MANY ACTEURS FILMS

            // Configuration de la relation Many-to-Many entre Acteurs et Films
            builder.HasOne(fa => fa.Acteurs) // MANY 2 MANY ACTEURS FILMS
                   .WithMany(a => a.FilmsActeurs)
                   .HasForeignKey(fk => fk.ActeursID);

            // Configuration de la relation Many-to-Many entre Acteurs et Films
            builder.HasOne(af => af.Films) // MANY 2 MANY ACTEURS FILMS
                   .WithMany(f => f.ActeursFilms)
                   .HasForeignKey(fk => fk.FilmsID);

            // Ajout de données pour la table intermédiaire MM_Films_Acteurs
            builder.HasData(
                new MM_Films_Acteurs
                {
                    ActeursID = 1, //"Mark Hammil"
                    FilmsID = 1 //"Star Wars : Un nouvel espoir"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 1, //"Mark Hammil"
                    FilmsID = 2 //"Star Wars : L'empire contre-attaque"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 1, //"Mark Hammil"
                    FilmsID = 3 //"Star Wars : Le retour du Jedi"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 2, // Charlie Hunnam
                    FilmsID = 4 //"Hooligans"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 3, // Elijah Wood
                    FilmsID = 5 //"LOTR - La communauté de l'anneau"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 3, // Elijah Wood
                    FilmsID = 6 //"LOTR - Les deux tours"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 3, // Elijah Wood
                    FilmsID = 7 //"LOTR - Le retour du roi"
                }
            );
        }
    }
}

