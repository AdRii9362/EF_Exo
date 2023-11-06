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
    public class MM_Films_Acteurs_Config : IEntityTypeConfiguration<MM_Films_Acteurs>
    {
        public void Configure(EntityTypeBuilder<MM_Films_Acteurs> builder)
        {

            builder.HasKey(fa => new { fa.ActeursID, fa.FilmsID });

            builder.HasOne(fa => fa.Acteurs)
                   .WithMany(a => a.FilmsActeurs)
                   .HasForeignKey(fk => fk.ActeursID);

            builder.HasOne(af => af.Films)
                   .WithMany(f => f.ActeursFilms)
                   .HasForeignKey(fk => fk.FilmsID);

            builder.HasData
                (
                new MM_Films_Acteurs
                {
                    ActeursID = 1, //"Mark Hammil"
                    FilmsID = 1 //"Star Wars : Un nouvel espoir"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 1,//"Mark Hammil"
                    FilmsID = 2 //"Star Wars : L'empire contre-attaque"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 1,//"Mark Hammil"
                    FilmsID = 3//"Star Wars : Le retour du Jedi"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 2, // Charlie Hunnam
                    FilmsID = 4 //"Hooligans",
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 3,//Elijah Wood
                    FilmsID = 5 //"LOTR - La communauté de l'anneau"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 3,//Elijah Wood
                    FilmsID = 6 //"LOTR - Les deux tours"
                },
                new MM_Films_Acteurs
                {
                    ActeursID = 3,//Elijah Wood
                    FilmsID = 7 //"LOTR - Le retour du roi",
                }
                );
        }
    }
}
