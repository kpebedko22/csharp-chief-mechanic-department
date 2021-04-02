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

        public override string ToString()
        {
            return name;
        }
    }
}
