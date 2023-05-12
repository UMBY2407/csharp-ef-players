using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_ef_players
{
	[Table("player")]
	[Index(nameof(PlayerId), IsUnique = true)]
	public class Player
	{
		[Key]
		public int PlayerId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Score { get; set; }
		public int NumberOfMatchesPlayed { get; set; }
		public int NumberOfMatchesWon { get; set; }

		public Player(string Name, string Surname, int NumberOfMatchesPlayed, int NumberOfMatchesWon)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.NumberOfMatchesPlayed = NumberOfMatchesPlayed;
			this.NumberOfMatchesWon = NumberOfMatchesWon;
		}

		public override string ToString()
		{
			string rapprStringa = "- Giocatore: " + PlayerId + ", Nome: " + Name + ", Cognome: " + Surname + ", Punteggio: " + Score + ", Partite Giocate: " + NumberOfMatchesPlayed + ", Partite Vinte: " + NumberOfMatchesWon;
			return rapprStringa;
		}
	}
}