using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using csharp_ef_players;
using (SportContext db = new SportContext())
{
	//Create
	Team Team1 = new Team("Juventus", "Torino", "Allegri", "Bianco-Nero");
	/*
	db.Add(Team1);
	db.SaveChanges();
	Console.WriteLine("Squadra creata:");
	Console.WriteLine(Team1.ToString());
	*/
	Player newPlayer1 = new Player ("Leonardo", "Bonucci", 500, 319);
	db.Add(newPlayer1);
	db.SaveChanges();
	//Console.WriteLine($"Giocatore aggiunto alla Squadra: " + Team1.Name);
	Console.WriteLine(newPlayer1.ToString());
	/*
	Player loadedPlayer = db.Players.Where(player => m.Surname == "Bonucci").First();
	db.Remove(loadedPlayer);
	db.SaveChanges();
	*/

	Player newPlayer2 = new Player("Federico", "Chiesa", 89, 54);
	db.Add(newPlayer2);
	db.SaveChanges();
	//Console.WriteLine($"Giocatore aggiunto alla Squadra: " + Team1.Name);
	Console.WriteLine(newPlayer2.ToString());
	/*
	Player loadedPlayer = db.Players.Where(player => m.Surname == "Chiesa").First();
	db.Remove(loadedPlayer);
	db.SaveChanges();
	*/

	Player newPlayer3 = new Player("Da Silva", "Danilo", 159, 97);
	db.Add(newPlayer3);
	db.SaveChanges();
	//Console.WriteLine($"Giocatore aggiunto alla Squadra: " + Team1.Name);
	Console.WriteLine(newPlayer3.ToString());
	/*
	Player loadedPlayer = db.Players.Where(player => m.Surname == "Danilo").First();
	db.Remove(loadedPlayer);
	db.SaveChanges();
	*/

	// Read

	Console.WriteLine("Recupero lista di giocatori");
	List<Player> players = db.Players.OrderBy(players => players.Name).ToList<Player>();

	//Update
	/*
	newPlayer1.Name = "Gianluigi";
	db.SaveChanges();
	*/
}