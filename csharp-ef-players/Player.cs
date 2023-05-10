using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Table("Player")]

public class Player
{
	[Key]
	public int PlayerId { get; set; }
	public string? Name { get; set; }
	public string Surname { get; set; }
	public int Score { get; set; }
	public int NumberOfMatchesPlayed { get; set; }
	public int NumberOfMatchesWon { get; set; }

}