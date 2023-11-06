using EF_Exo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Espace de noms pour la configuration liée à l'exercice Entity Framework
namespace EF_Exo.Configs
{
    // Classe de configuration pour l'entité Acteurs
    public class ActeursConfig : IEntityTypeConfiguration<Acteurs>
    {
        // Méthode de configuration pour l'entité Acteurs
        public void Configure(EntityTypeBuilder<Acteurs> builder)
        {
            // Définition de la clé primaire pour l'entité Acteurs sur la propriété ID
            builder.HasKey(a => a.ID);
            // Configuration de la propriété ID pour qu'elle soit générée et incrémentée lors de l'ajout à la base de données
            builder.Property(a => a.ID).ValueGeneratedOnAdd();

            // Configuration de la propriété Prenom pour qu'elle soit requise et ait une longueur maximale de 100
            builder.Property(a => a.Prenom).IsRequired().HasMaxLength(100);
            // Configuration de la propriété Nom pour qu'elle soit requise et ait une longueur maximale de 100
            builder.Property(a => a.Nom).IsRequired().HasMaxLength(100);

            // Ajout de données de départ pour l'entité Acteurs
            builder.HasData(
                 new Acteurs
                 {
                     ID = 1,
                     Prenom = "Mark",
                     Nom = "Hammil"
                 },
                 new Acteurs
                 {
                     ID = 2,
                     Prenom = "Charlie",
                     Nom = "Hunnam"
                 },
                 new Acteurs
                 {
                     ID = 3,
                     Prenom = "Elijah",
                     Nom = "Wood"
                 }
            );
        }
    }
}



