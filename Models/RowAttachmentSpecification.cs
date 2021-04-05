using System;
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
		public DbSet<RowAttachmentSpecification> RowsAttachmentSpecification { get; set; }
	}

	[Table("row_attachment_specification")]
	public class RowAttachmentSpecification
	{
		[Key]
		public int PK_Row_Attachment_Specification { get; set; }
		public int amount { get; set; }
		public int PK_Leasing_Contract { get; set; }
		public int PK_Equipment_Group { get; set; }

		public LeasingContract LeasingContract { get { return Program.db.LeasingContracts.Find(PK_Leasing_Contract); } }
		public EquipmentGroup EquipmentGroup { get { return Program.db.EquipmentGroups.Find(PK_Equipment_Group); } }

	}

}
