using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    public class Realisateurs : Personnes
    {
        public List<Films> Films { get; set; } // one 2 many avec acteurs
     
    }
}
