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
        public DbSet<Equipment> Equipments { get; set; }
    }

    [Table("equipment")]
    public class Equipment
    {
        [Key]
        public int PK_Equipment { get; set; }

        public string name { get; set; }
        public string serial_number { get; set; }
        public string inventory_number { get; set; }
        public Decimal cost { get; set; }
        public int PK_Equipment_Group { get; set; }

        public bool is_debit { get; set; }
        public bool is_leasing { get; set; }

        public EquipmentGroup equipment_Group { get { return Program.db.EquipmentGroups.Find(PK_Equipment_Group); } }

        public int PK_Workshop 
        { 
            get 
            { 
                if (equipment_Group != null)
                    return this.equipment_Group.PK_Workshop;
                return -1;
            } 
        }

        public Workshop workshop { get { return Program.db.Workshops.Find(PK_Workshop); } }

        public override string ToString()
        {
            return name;
        }
    }
}
