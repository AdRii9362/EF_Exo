using EF_Exo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

// Espace de noms pour la configuration liée à l'exercice Entity Framework
namespace EF_Exo.Configs
{
    // Espace de noms pour la configuration liée à l'exercice Entity Framework
    namespace EF_Exo.Configs
    {
        // Classe de configuration pour l'entité Realisateurs
        internal class RealisateursConfig : IEntityTypeConfiguration<Realisateurs>
        {
            // Méthode de configuration pour l'entité Realisateurs
            public void Configure(EntityTypeBuilder<Realisateurs> builder)
            {
                // Définition de la clé primaire pour l'entité Realisateurs sur la propriété ID
                builder.HasKey(r => r.ID);
                // Configuration de la propriété ID pour qu'elle soit générée et incrémentée lors de l'ajout à la base de données
                builder.Property(r => r.ID).ValueGeneratedOnAdd();

                // Configuration de la propriété Prenom pour qu'elle soit requise (NOT NULL) et ait une longueur maximale de 100
                builder.Property(r => r.Prenom).IsRequired().HasMaxLength(100);
                // Configuration de la propriété Nom pour qu'elle soit requise (NOT NULL) et ait une longueur maximale de 100
                builder.Property(r => r.Nom).IsRequired().HasMaxLength(100);

                // Configuration de la relation entre Realisateurs et Films, indiquant qu'un réalisateur peut avoir plusieurs films
                builder.HasMany(f => f.Films).WithOne(r => r.Realisateurs).IsRequired();

                // Ajout de données de départ pour l'entité Realisateurs
                builder.HasData(
                    new Realisateurs
                    {
                        ID = 1,
                        Prenom = "Georges",
                        Nom = "Lucas"
                    },
                    new Realisateurs
                    {
                        ID = 2,
                        Prenom = "Lexi",
                        Nom = "Alexander"
                    },
                    new Realisateurs
                    {
                        ID = 3,
                        Prenom = "Peter",
                        Nom = "Jackson"
                    });
            }
        }
    }

}

