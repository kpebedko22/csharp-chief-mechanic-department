using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OGM.Models {


    public partial class OGMContext : DbContext {
        public DbSet<ReasonDebit> ReasonDebits { get; set; }
    }

    [Table("reason_debit")]
    public class ReasonDebit {
        [Key]
        public int PK_Reason_Debit { get; set; }

        public string code { get; set; }

        public string name { get; set; }

        public bool is_there_any_row()
        {
            using (OGMContext db = new OGMContext())
            {
                if (db.DebitEquipments.Where(d => d.PK_Reason_Debit == PK_Reason_Debit).Count() > 0)
                    return true;
                return false;
            }
        }

        public override string ToString() {
            return name;
        }
    }
}
