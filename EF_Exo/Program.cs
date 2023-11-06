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

DataContext dc = new DataContext();


#region ajouter un film
//Ajouter le film “Pacific Rim” (Acteur principal : Charlie Hunnam, Réal : Guillermo Del Toro, Année : 2013,Genre: Action)

Films f = new Films { };

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
//     {
//           Console.WriteLine(ex.Message);
//}


#endregion




//Chaque film n’aura qu’un seul réalisateur, mais plusieurs acteurs possibles.
//2) Effectuer les changements nécessaires dans la classe Film et mettre à jour la base
//de données pour qu’elle puisse accueillir un nouveau jeu de données.
//3) Afficher tous les films avec réalisateur et acteurs.