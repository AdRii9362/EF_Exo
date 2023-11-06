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
            builder.HasKey(f => f.Id); //.HASKEY => DECLARATION DE LA CLEF PRIMAIRE
            builder.Property(f => f.Id).ValueGeneratedOnAdd(); // PROPRIETES DE LA CLE PRIMARE: .VALUEGENERATEDONADD = INCREMENTATION AUTO

            builder.HasIndex(f => f.Titre).IsUnique(); // ISUNIQUE EST UNIQUEMENT APPLICABLE SUR UN INDEX, ON DECLARE DONC LA VARIABLE EN .HASINDEX POUR Y AJOUTER ISUNIQUE
            builder.Property(f=> f.Titre).IsRequired().HasMaxLength(100);// ISREQUIRED = NOT NULL , HASMAXLENGHT() = ON LIMITE LA TAILLE DU STRING

            builder.HasCheckConstraint("CK_AnneeSortie", "AnneeSortie>1975");// HASCHECKCONTRAINT PERMET D APPLIQUER UNE CONTRAINTE DE VERIFICATION, ON NOMME LA CONTRAINTE ET ON REALSIE LA CONTRAINTE
            
            builder.Property(f=>f.Genre).IsRequired().HasMaxLength(100);

            builder.HasData( //ON VA COMPLETER LES DONNEES DANS NOS VARIABLES
                new Films //NOUVEL OBJET FILMS
                {
                    Id = 1, //VARIABLE DE L ENTITEE FILMS 
                    Titre = "Star Wars : Un nouvel espoir",
                    AnneeSortie = 1977,
                    Genre = "Science-Fiction",
                    RealisateursID = 1
                },
                new Films
                {
                    Id = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    AnneeSortie = 1980,
                    Genre = "Science-Fiction",
                    RealisateursID = 1


                },
                new Films
                {
                    Id = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    AnneeSortie = 1983,
                    Genre = "Science-Fiction",
                    RealisateursID = 1
                },
                new Films
                {
                    Id = 4,
                    Titre = "Hooligans",
                    AnneeSortie = 2005,
                    Genre = "Société",
                    RealisateursID = 2
                },
                new Films
                {
                    Id = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    AnneeSortie = 2001,
                    Genre = "Heroic-Fantasy",
                    RealisateursID = 3
                },
                new Films
                {
                    Id = 6,
                    Titre = "LOTR - Les deux tours",
                    AnneeSortie = 2002,
                    Genre = "Heroic-Fantasy",
                    RealisateursID = 3
                },
                new Films
                {
                    Id = 7,
                    Titre = "LOTR - Le retour du roi",
                    AnneeSortie = 2003,
                    Genre = "Heroic-Fantasy",
                    RealisateursID = 3
                }
                ) ;

        }

    }      
}
