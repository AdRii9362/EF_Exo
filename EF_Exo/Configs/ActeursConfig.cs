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

namespace EF_Exo.Configs
{
    public class ActeursConfig : IEntityTypeConfiguration<Acteurs>
    {
        public void Configure(EntityTypeBuilder<Acteurs> builder)
        {

            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).ValueGeneratedOnAdd();

            builder.Property(a => a.Prenom).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Nom).IsRequired().HasMaxLength(100);



            builder.HasData(
                 new Acteurs
                 {
                     ID=1,
                     Prenom = "Mark",
                     Nom= "Hammil"
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

                 ) ;


        }
    }
}
