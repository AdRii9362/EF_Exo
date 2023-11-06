using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    // Classe Realisateurs héritant de la classe Personnes
    public class Realisateurs : Personnes
    {
        public List<Films> Films { get; set; } // Relation One-to-Many avec la classe Films
    }

}
