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

        public int contract_number { get; set; }

        [Column(TypeName = "Date")]
        public DateTime date { get; set; }

        [Column(TypeName = "Date")]
        public DateTime date_delivery { get; set; }
        public int period_of_use { get; set; }
        public string address_delivery { get; set; }
        public int days_for_first_payment { get; set; }
        public int days_for_report { get; set; }
        public int penalty { get; set; }
        public int max_penalty { get; set; }
        public int days_for_force_majeure { get; set; }
        public Decimal penalty_fee { get; set; }

        public Organization leaser 
        { 
            get 
            {
                int PK_Role = 2; // 2 - роль лизингодателя
                List<RelationshipOrganizationLeasingContract> temp = Program.db.relationships_organization_leasing_contract.FromSqlRaw($"SELECT * FROM relationship_organization_leasing_contract" +
                    $" WHERE PK_Leasing_Contract = {PK_Leasing_Contract} AND PK_Role = {PK_Role}").ToList();

                if (temp.Count > 0)
                    return temp.ElementAt(0).Organization;

                return null;
            } 
        }


        public Organization seller
        {
            get
            {
                int PK_Role = 3; // 3 - роль продавца
                List<RelationshipOrganizationLeasingContract> temp = Program.db.relationships_organization_leasing_contract.FromSqlRaw($"SELECT * FROM relationship_organization_leasing_contract" +
                    $" WHERE PK_Leasing_Contract = {PK_Leasing_Contract} AND PK_Role = {PK_Role}").ToList();

                if (temp.Count > 0)
                    return temp.ElementAt(0).Organization;

                return null;
            }
        }

        public override string ToString()
        {
            return Convert.ToString(contract_number);
        }
    }

}
