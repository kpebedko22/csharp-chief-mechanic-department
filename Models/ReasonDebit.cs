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

        public override string ToString() {
            return name;
        }
    }
}
