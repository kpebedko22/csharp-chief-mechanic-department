﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OGM.Models
{
	public partial class OGMContext : DbContext
	{
		public DbSet<RelationshipOrganizationLeasingContract> relationships_organization_leasing_contract { get; set; }
	}



	[Table("relationship_organization_leasing_contract")]
	public class RelationshipOrganizationLeasingContract
	{
		[Key]
		public int PK { get; set; }

		[ForeignKey("PK_Leasing_Contract")]
		public int PK_Leasing_Contract { get; set; }

		[ForeignKey("PK_Organization")]
		public int PK_Organization { get; set; }

		[ForeignKey("PK_Role")]
		public int? PK_Role { get; set; }


		public LeasingContract Leasing_Contract { get { return Program.db.LeasingContracts.Find(PK_Leasing_Contract); } }
		public Organization Organization { get { return Program.db.Organizations.Find(PK_Organization); } }
		public Role Role { get { return Program.db.Roles.Find(PK_Role); } }



	}

}
