using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1) Mettre en place une classe d’entité Personne (id, nom, prenom). Ces personnes
//pourront être acteur et/ou réalisateur dans un film.
namespace EF_Exo.Entities
{
    public class Personnes
    {
        public int ID { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }

    }
}
