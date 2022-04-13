// See https://aka.ms/new-console-template for more information
using AppLabGitkrakren;

Console.WriteLine("My first commit");
Console.WriteLine("Hello, World!");

List<Personne> personnes = new List<Personne>()
{
    new Personne{ Id = 1, Name = "Sakho", LastName= "Cheikh"},
    new Personne{Id=3, Name = "Sow", LastName = "Maham"},
    new Personne { Id = 2, Name = "Soumaré", LastName = "Nouma"}
};

var adresses = new Adresse { Id = 1, Ville = "Cergy", CodePostal = "95800", Pays = "France" };
