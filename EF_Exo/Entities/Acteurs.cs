using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    // Classe Acteurs héritant de la classe Personnes
    public class Acteurs : Personnes
    {
        public List<MM_Films_Acteurs> FilmsActeurs { get; set; } // Relation Many-to-Many avec la classe MM_Films_Acteurs
    }

}
