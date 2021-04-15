using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace OGM.Models {
	public partial class OGMContext : DbContext {
		public DbSet<Organization> Organizations { get; set; }
	}

	[Table("organization")]
	public class Organization {

		[Key]
		public int PK_Organization { get; set; }

		public string name { get; set; }

		public string legal_address { get; set; }

		public string mailing_address { get; set; }

		public string phone { get; set; }
		
		public string INN { get; set; }

		public string payment_account { get; set; }

		public string bank { get; set; }

		public string correspondent_account { get; set; }

		public string BIK { get; set; }

		public int PK_Role { get; set; }

		public Role Role { get { return Program.db.Roles.Find(PK_Role); } }

		public bool is_there_relationship()
		{
			using (OGMContext db = new OGMContext())
			{

				if (db.relationships_organization_leasing_contract.Where(r => r.PK_Organization == PK_Organization).Count() > 0)
					return true;
				return false;
			}
		}

		public override string ToString() { return name; }
	}
}
