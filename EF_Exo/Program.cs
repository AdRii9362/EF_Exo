using EF_Exo.Domain;
using EF_Exo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Linq;


//1. installer les packages (!!meme version du projet => 6)=> clic droit sur dependances => gerer paquet Nugets => MICROSOFT.ENTITYFRAMEWORKCORE / MICROSOFT.ENTITYFRAMEWORK.SQL / MICROSOFT.ENTITYFRAMEWORK.TOOLS 
//2. AFFICHER LA CONSOLE GESTIONNAIRE PACKAGE => AFFICHAGE, AUTRES FENETRES, CONSOLE GESTIONNAIRE DE PACKAGE
//3. on fait d abord Entities
//4.on configure le domaine - on cree la DB
//5. on fait la config
//6. dans la console de package, migrer vers la DB => add-migration NomDeLa Migration // update-database
//7. on cree un objet film

#region Explication Many2Many et One2Many
//Chaque film n’aura qu’un seul réalisateur, mais plusieurs acteurs possibles.
//2) Effectuer les changements nécessaires dans la classe Film et mettre à jour la base
//de données pour qu’elle puisse accueillir un nouveau jeu de données.
//3) Afficher tous les films avec réalisateur et acteurs.

/*La relation One-to-Many entre Films et Realisateurs est établie à l'aide de la propriété Realisateurs dans la classe Films. 
 Un film est associé à un seul réalisateur, ce qui est représenté par la propriété RealisateursID qui est la clé étrangère faisant référence à la table Realisateurs.

La relation Many-to-Many entre Films et Acteurs est mise en place à l'aide de la classe intermédiaire MM_Films_Acteurs. 
La liste ActeursFilms dans la classe Films représente la collection des acteurs associés à un film donné. Un film peut avoir plusieurs acteurs, et un acteur peut jouer dans plusieurs films.

En utilisant ces relations, vous pouvez établir des liens entre les entités Films, Realisateurs, Acteurs et MM_Films_Acteurs dans votre base de données, 
ce qui vous permet de modéliser efficacement les relations complexes entre ces différentes entités.*/

#endregion

DataContext dc = new DataContext();


#region ajouter un film
//Ajouter le film “Pacific Rim” (Acteur principal : Charlie Hunnam, Réal : Guillermo Del Toro, Année : 2013,Genre: Action)

//Films f = new Films { };

//Personnes a = new Acteurs { };
//Personnes r = new Realisateurs { };


//{
//    Titre = "Pacific Rim",
//    AnneeSortie = 2013,
//    Genre = "Action",
//    Realisateur = "Guillermo Del Toro",
//    ActeurPrincipale = "Charlie Hunnam"

//};
//dc.Films.Add(f);
//try
//{
//    dc.SaveChanges();
//}
//catch (DbUpdateException e)
//{
//    Console.WriteLine(e.Message);
//}

#endregion

#region Supprimer un film

//dc.Films.Remove(dc.Films.First(f => f.Id == 1));
//try
//{
//    dc.SaveChanges();
//}
//catch (DbUpdateException e)
//{
//    Console.WriteLine(e.Message);
//}

#endregion

#region Parcourir les données
//foreach (Films films in dc.Films)
//{

//    Console.WriteLine($"{films.Titre} | {films.AnneeSortie} | {films.Genre} | {films.Realisateur} | {films.ActeurPrincipale} ");
//}

#endregion

#region Modif Exo

//----------------------------------------------------------------------------------------------------

//Console.WriteLine("Film avant 2001");
//Console.WriteLine();

//// afficher film avant 2001

//foreach (Films films in dc.Films.Where(f => f.AnneeSortie < 2001))
//{

//    Console.WriteLine($"{films.Titre} | {films.AnneeSortie} | {films.Genre} | {films.Realisateur} | {films.ActeurPrincipale} ");
//}

//----------------------------------------------------------------------------------------------------

//update Mettre à jour tous les films Star Wars pour remplacer l’acteur principal par Harrison Ford

//try
//{   
//    foreach (Films films in dc.Films.Where(f => f.Titre.Contains("Star Wars")))
//    {

//        films.ActeurPrincipale = "Harrison Ford";


//    }

//    dc.SaveChanges();

//}
//catch(DbUpdateException ex)
//{
//    Console.WriteLine(ex.Message);

//}

//----------------------------------------------------------------------------------------------------

//Supprimer tous les films de Charlie Hunnam
//try
//{

//      foreach (Films films in dc.Films.Where(f => f.ActeurPrincipale.Equals("Charlie Hunnam")))
//       {
//           dc.Remove(films);

//       }
//
//           dc.SaveChanges();
//}
//catch (DbUpdateException ex)
//       {
//           Console.WriteLine(ex.Message);
//       }


#endregion
//Methode 1

// Requête pour récupérer les informations des films, réalisateurs et acteurs associés
var TabFilmRealisateurActeur = from f in dc.Films
                               join r in dc.Realisateurs on f.RealisateursID equals r.ID // Jointure entre Films et Realisateurs basée sur RealisateursID et ID
                               from fa in dc.MM_Films_Acteurs
                               join a in dc.Acteurs on fa.ActeursID equals a.ID // Jointure entre MM_Films_Acteurs et Acteurs basée sur ActeursID et ID
                               where fa.FilmsID == f.Id // Filtre pour s'assurer que les IDs de films correspondent
                               select new
                               {
                                   TitreFilm = f.Titre, // Sélection du titre du film
                                   GenreFilm = f.Genre, // Sélection du genre du film
                                   DateAnneeSortie = f.AnneeSortie, // Sélection de l'année de sortie du film
                                   Realisateur = r.Prenom + " " + r.Nom, // Concaténation du prénom et du nom du réalisateur
                                   Acteur = a.Prenom + " " + a.Nom // Concaténation du prénom et du nom de l'acteur
                               };

// Affichage des résultats à l'aide d'une boucle foreach
foreach (var items in TabFilmRealisateurActeur)
{
    Console.WriteLine($"Film : {items.TitreFilm}|Genre : {items.GenreFilm}| Annee de sortie : {items.DateAnneeSortie}| Realisateur : {items.Realisateur} | Acteur : {items.Acteur}"); // Affichage des détails du film, du réalisateur et de l'acteur associé
}

Console.WriteLine();

//Methode 2

// Requête pour récupérer les informations des films, réalisateurs et acteurs associés
var TabFilmRealisateurActeurs = dc.Films
    .Join(dc.Realisateurs, f => f.RealisateursID, r => r.ID, (f, r) => new { Film = f, Realisateur = r }) // Jointure entre Films et Realisateurs
    .Join(dc.MM_Films_Acteurs, fr => fr.Film.Id, fa => fa.FilmsID, (fr, fa) => new { fr.Film, fr.Realisateur, MM_Films_Acteurs = fa }) // Jointure entre la première jointure et MM_Films_Acteurs
    .Join(dc.Acteurs, fra => fra.MM_Films_Acteurs.ActeursID, a => a.ID, (fra, a) => new { fra.Film, fra.Realisateur, fra.MM_Films_Acteurs, Acteur = a }) // Jointure entre la deuxième jointure et Acteurs
    .Where(fraa => fraa.Film.Id == fraa.MM_Films_Acteurs.FilmsID) // Filtre pour s'assurer que les IDs de films correspondent
    .Select(result => new
    {
        result.Film.Titre, // Sélection du titre du film
        result.Film.Genre,
        result.Film.AnneeSortie,
        Realisateur = result.Realisateur.Prenom + " " + result.Realisateur.Nom, // Concaténation du prénom et du nom du réalisateur
        Acteur = result.Acteur.Prenom + " " + result.Acteur.Nom // Concaténation du prénom et du nom de l'acteur
    });

// Affichage des résultats à l'aide d'une boucle foreach
foreach (var item in TabFilmRealisateurActeurs)
{
    Console.WriteLine($"Film : {item.Titre}, Annee de sortie :{item.AnneeSortie},Genre du film : {item.Genre}, Réalisateur : {item.Realisateur}, Acteur : {item.Acteur}"); // Affichage des détails du film, du réalisateur et de l'acteur associé
}









