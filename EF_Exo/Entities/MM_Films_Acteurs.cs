using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Exo.Entities
{
    public class MM_Films_Acteurs //classe intermédiraire Many 2 Many entre Films et Acteurs
    {
        public Acteurs Acteurs { get; set; }
        public int ActeursID { get; set; }


        public Films Films { get; set; }
        public int FilmsID { get; set; }
    }
}
