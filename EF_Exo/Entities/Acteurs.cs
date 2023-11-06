using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    public class Acteurs : Personnes
    {
        public List<MM_Films_Acteurs> FilmsActeurs { get; set; } // many 2 many avec Acteurs

    }
}
