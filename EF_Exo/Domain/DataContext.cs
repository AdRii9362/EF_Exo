using EF_Exo.Configs;
using EF_Exo.Configs.EF_Exo.Configs;
using EF_Exo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EF_Exo.Domain
{
    // Classe de contexte de données DataContext héritant de DbContext
    public class DataContext : DbContext
    {
        public DbSet<Films> Films { get; set; } // DbSet pour l'entité Films
        public DbSet<Acteurs> Acteurs { get; set; } // DbSet pour l'entité Acteurs
        public DbSet<Realisateurs> Realisateurs { get; set; } // DbSet pour l'entité Realisateurs
        public DbSet<MM_Films_Acteurs> MM_Films_Acteurs { get; set; } // DbSet pour l'entité MM_Films_Acteurs

        private string cs = @"Data Source=GOS-VDI206\TFTIC;Initial Catalog=DB_Films_EF;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs); // Établit la relation avec la base de données
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmsConfig()); // Applique la configuration pour l'entité Films
            modelBuilder.ApplyConfiguration(new ActeursConfig()); // Applique la configuration pour l'entité Acteurs
            modelBuilder.ApplyConfiguration(new RealisateursConfig()); // Applique la configuration pour l'entité Realisateurs
            modelBuilder.ApplyConfiguration(new MM_Films_Acteurs_Config()); // Applique la configuration pour l'entité MM_Films_Acteurs
        }
    }
}
