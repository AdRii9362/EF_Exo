using EF_Exo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Configs
{
    internal class RealisateursConfig : IEntityTypeConfiguration<Realisateurs>
    {
        public void Configure(EntityTypeBuilder<Realisateurs> builder)
        {


            builder.HasKey(r => r.ID);
            builder.Property(r => r.ID).ValueGeneratedOnAdd();



            builder.Property(r => r.Prenom).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Nom).IsRequired().HasMaxLength(100);



            builder.HasMany(f => f.Films).WithOne(r => r.Realisateurs).IsRequired();


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
