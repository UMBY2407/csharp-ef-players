using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
	[Table("team")]
	public class Team
	{
		public int TeamId { get; set; }
		public string? Name { get; set; }
		public string? City { get; set; }
		public string? Coach { get; set; }
		public string? Colors { get; set; }
	}
}
