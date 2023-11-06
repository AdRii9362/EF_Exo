using EF_Exo.Configs;
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
    public class DataContext : DbContext
    {
        public DbSet<Films> Films { get; set; }
        public DbSet<Acteurs> Acteurs { get; set; }
        public DbSet < Realisateurs> Realisateurs { get; set; }
        public DbSet <MM_Films_Acteurs>MM_Films_Acteurs { get; set; }



        private string cs = @"Data Source=GOS-VDI206\TFTIC;Initial Catalog=DB_Films_EF;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs); //fait la relation avec la DB
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmsConfig());
            modelBuilder.ApplyConfiguration(new ActeursConfig());
            modelBuilder.ApplyConfiguration(new RealisateursConfig());
            modelBuilder.ApplyConfiguration(new MM_Films_Acteurs_Config());

        }

    }


}
