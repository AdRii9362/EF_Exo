using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Espace de noms pour les entités liées à l'exercice Entity Framework
namespace EF_Exo.Entities
{
    // Classe intermédiaire représentant la relation Many-to-Many entre Films et Acteurs
    public class MM_Films_Acteurs
    {
        // Propriété représentant l'acteur associé à cette relation
        public Acteurs Acteurs { get; set; }
        // Identifiant de l'acteur correspondant
        public int ActeursID { get; set; }

        // Propriété représentant le film associé à cette relation
        public Films Films { get; set; }
        // Identifiant du film correspondant
        public int FilmsID { get; set; }
    }
}

