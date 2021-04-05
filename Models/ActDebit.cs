using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



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


		// нахуй это вообще тут???
		public int PK_Equipment_Group { get; set; }

		public EquipmentGroup EquipmentGroup {
			get {
				return Program.db.EquipmentGroups.Find(PK_Equipment_Group);
			}
		}

		// когда будет тип строка акта списания
		/*public List<DebitEquipment> GetDebitEquipment() {
			return Program.db.DebitEquipment.Where(b => b.PK_Aсt_Debit == PK_Act_Debit).ToList();
		}*/
	}
}
