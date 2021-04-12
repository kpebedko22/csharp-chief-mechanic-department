using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace OGM.Models {

	public partial class OGMContext : DbContext {
		public DbSet<ActDebit> ActDebits { get; set; }
	}

	[Table("aсt_debit")]
	public class ActDebit {

		public override string ToString() {
			return act_number;
		}

		[Key]
		public int PK_Aсt_Debit { get; set; }

		public string act_number { get; set; }

		[Column(TypeName = "Date")]
		public DateTime date { get; set; }

		// когда будет тип строка акта списания
		public List<DebitEquipment> GetDebitEquipments() {
			return Program.db.DebitEquipments.Where(b => b.PK_Aсt_Debit == PK_Aсt_Debit).ToList();
		}
	}
}
