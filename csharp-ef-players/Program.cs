﻿using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using csharp_ef_players;
using (SportContext db = new SportContext())
{
	//Create
	Player newPlayer = new Player ( 1, "Alessandro", "Del Piero", 705, 387);
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