using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OGM.Models {

	public partial class OGMContext : DbContext {
		public DbSet<Role> Roles { get; set; }
	}

	[Table("role")]
	public class Role {

		[Key]
		public int PK_Role { get; set; }

		public string name { get; set; }

		public override string ToString() {
			return name;
		}
	}
}
