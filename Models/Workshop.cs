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
        public DbSet<Workshop> Workshops { get; set; }
    }

    [Table("workshop")]
    public class Workshop
    {
        [Key]
        public int PK_Workshop { get; set; }

        public string name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }

        public bool is_there_group()
        {
            using (OGMContext db = new OGMContext())
            {
                if (db.EquipmentGroups.Where(g => g.PK_Workshop == PK_Workshop).Count() > 0)
                    return true;
                return false;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }

}
