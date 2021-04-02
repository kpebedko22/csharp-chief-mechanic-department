﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


using System.Windows.Forms;

namespace OGM.Models
{
    public partial class OGMContext : DbContext
    {

        public OGMContext()
        {


            try
            {
                Database.EnsureCreated();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=37.59.55.185;user=ZQ73KRwNC8;password=m6PnNvjtXJ;database=ZQ73KRwNC8;"
            );
        }

    }
}
