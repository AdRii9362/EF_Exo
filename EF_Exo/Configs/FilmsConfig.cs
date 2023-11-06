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
    public class FilmsConfig : IEntityTypeConfiguration<Films>
    {
        public void Configure(EntityTypeBuilder<Films> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).ValueGeneratedOnAdd();

            builder.HasIndex(f => f.Titre);
            builder.Property(f=> f.Titre).IsRequired().HasMaxLength(100);

            builder.HasCheckConstraint("CK_AnneeSortie", "AnneeSortie>1975");
            
            builder.Property(f=>f.Genre).IsRequired().HasMaxLength(100);

            //builder.Property(f=> f.Realisateurs).IsRequired().HasMaxLength(100);





            builder.HasData(
                new Films
                {
                    Id = 1,
                    Titre = "Star Wars : Un nouvel espoir",
                    AnneeSortie = 1977,
                    Genre = "Science-Fiction",
                },
                new Films
                {
                    Id = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    AnneeSortie = 1980,
                    Genre = "Science-Fiction"
                },
                new Films
                {
                    Id = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    AnneeSortie = 1983,
                    Genre = "Science-Fiction"
                },
                new Films
                {
                    Id = 4,
                    Titre = "Hooligans",
                    AnneeSortie = 2005,
                    Genre = "Société"
                },
                new Films
                {
                    Id = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    AnneeSortie = 2001,
                    Genre = "Heroic-Fantasy"
                },
                new Films
                {
                    Id = 6,
                    Titre = "LOTR - Les deux tours",
                    AnneeSortie = 2002,
                    Genre = "Heroic-Fantasy"
                },
                new Films
                {
                    Id = 7,
                    Titre = "LOTR - Le retour du roi",
                    AnneeSortie = 2003,
                    Genre = "Heroic-Fantasy"
                }
                );

        }

    }      
}
