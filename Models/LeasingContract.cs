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
        public DbSet<LeasingContract> LeasingContracts { get; set; }
    }

    [Table("leasing_contract")]
    public class LeasingContract
    {
        [Key]
        public int PK_Leasing_Contract { get; set; }

        public string contract_number { get; set; }

        [Column(TypeName = "Date")]
        public DateTime date { get; set; }

        [Column(TypeName = "Date")]
        public DateTime date_delivery { get; set; }

        [Column(TypeName = "Date")]
        public DateTime date_end { get; set; }
        public string period_of_use { get; set; }
        public string address_delivery { get; set; }
        public int days_for_first_payment { get; set; }
        public int days_for_report { get; set; }
        public Decimal penalty { get; set; }
        public Decimal max_penalty { get; set; }
        public int days_for_force_majeure { get; set; }
        public Decimal penalty_fee { get; set; }

        private Organization GetOrganizationByRole(int PK_Role)
        {
            List<RelationshipOrganizationLeasingContract> temp = Program.db.relationships_organization_leasing_contract
            .Where(b => b.PK_Leasing_Contract == PK_Leasing_Contract && b.PK_Role == PK_Role).ToList();

            //if (temp.Count > 0)
              //  return temp.ElementAt(0).Organization;


            return null;
        }

        public Organization leaser { get { return GetOrganizationByRole(2); } }

        public Organization seller { get { return GetOrganizationByRole(3); } }

        public String view { get { return "Просмотреть"; } }

        public override string ToString()
        {
            return contract_number;
        }
    }

}
