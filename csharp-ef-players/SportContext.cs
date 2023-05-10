using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
	public class SportContext : DbContext
	{
		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=PC-DI-UMBERTO\\MSSQLSERVER15;Initial Catalog=EFPlayers;" + "Integrated Security=True;TrustServerCertificate=True");
		}
	}
}
