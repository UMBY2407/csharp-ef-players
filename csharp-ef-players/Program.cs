using csharp_ef_players;
using (SportContext db = new SportContext())
{
	//Create
	Player newPlayer = new Player {PlayerId = 1, Name = "Alessandro", Surname = "Del Piero", NumberOfMatchesPlayed = 705, NumberOfMatchesWon = 387};
	db.Add(newPlayer);
	db.SaveChanges();

	// Read
	Console.WriteLine("Recupero lista di giocatori");
	List<Player> players = db.Players.OrderBy(players => players.Name).ToList<Player>();

	//Update
	newPlayer.Name = "Gianluigi";
	db.SaveChanges();

	//Delete
	db.Remove(newPlayer);
	db.SaveChanges();
}