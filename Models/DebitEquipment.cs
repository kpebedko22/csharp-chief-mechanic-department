using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OGM.Models {

	public partial class OGMContext : DbContext {
		public DbSet<DebitEquipment> DebitEquipments { get; set; }
	}

	[Table("debit_equipment")]
	public class DebitEquipment {

		// хз че тут возвращать в качестве строки - ну пусть будет это
		// либо номер акта вместо причины - хз
		public override string ToString() {
			return inventory_number + " " + ReasonDebit.ToString();
		}

		[Key]
		public int PK_Debit_Equipment { get; set; }

		public string inventory_number { get; set; }

		public int PK_Reason_Debit { get; set; }

		public ReasonDebit ReasonDebit {
			get {
				return Program.db.ReasonDebits.Find(PK_Reason_Debit);
			}
		}

		public int PK_Aсt_Debit { get; set; }

		public ActDebit ActDebit {
			get {
				return Program.db.ActDebits.Find(PK_Aсt_Debit);
			}
		}

		public int PK_Equipment_Group { get; set; }

		public EquipmentGroup EquipmentGroup {
			get {
				return Program.db.EquipmentGroups.Find(PK_Equipment_Group);
			}
		}

		public Workshop Workshop {
			get {
				return EquipmentGroup.workshop;
			}
		}

		public string name { get; set; }

		public decimal cost { get; set; }
	}
}
