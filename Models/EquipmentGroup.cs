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
        public DbSet<EquipmentGroup> EquipmentGroups { get; set; }
    }

    [Table("equipment_group")]
    public class EquipmentGroup
    {
        [Key]
        public int PK_Equipment_Group { get; set; }

        public string name { get; set; }
        public string сipher { get; set; }
        public int PK_Workshop { get; set; }

        public Workshop workshop { get { return Program.db.Workshops.Find(PK_Workshop); } }

        public bool is_there_relationships()
        {
            using (OGMContext db = new OGMContext())
            {
                if (db.Equipments.Where(g => g.PK_Equipment_Group == PK_Equipment_Group).Count() > 0
                   || db.RowsAttachmentSpecification.Where(g => g.PK_Equipment_Group == PK_Equipment_Group).Count() > 0
                   || db.DebitEquipments.Where(g => g.PK_Equipment_Group == PK_Equipment_Group).Count() > 0)
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
