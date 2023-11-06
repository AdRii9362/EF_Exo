using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    // Classe Films
    public class Films
    {
        public int Id { get; set; } // Identifiant du film
        public string Titre { get; set; } // Titre du film
        public int AnneeSortie { get; set; } // Année de sortie du film
        public string Genre { get; set; } // Genre du film

        public Realisateurs Realisateurs { get; set; } // Relation One-to-Many avec la classe Realisateurs
        public int RealisateursID { get; set; } // Clé étrangère pour la relation One-to-Many avec la classe Realisateurs

        public List<MM_Films_Acteurs>? ActeursFilms { get; set; } // Relation Many-to-Many avec la classe MM_Films_Acteurs
    }

}
