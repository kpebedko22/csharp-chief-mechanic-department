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
        public DbSet<OGM.Equipment> Equipments { get; set; }
    }

    [Table("equipment")]
    public class Equipment
    {
        [Key]
        public int PK_Equipment { get; set; }

        public string name { get; set; }
        public string serial_number { get; set; }
        public string inventory_number { get; set; }
        public double cost { get; set; }
        public int PK_EquipmentGroup { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
