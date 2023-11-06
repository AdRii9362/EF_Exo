using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    public class Films
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public string Genre { get; set; }

        public Realisateurs Realisateurs { get; set;} // one 2 many avec Films
        


        public List<MM_Films_Acteurs>? ActeursFilms { get; set; } // many 2 many avec films
    }
}
