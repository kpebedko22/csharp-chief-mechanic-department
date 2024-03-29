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
            optionsBuilder.UseMySQL(
                //"server=37.59.55.185;user=ZQ73KRwNC8;password=m6PnNvjtXJ;database=ZQ73KRwNC8;" // беплатная удалённая бд
                //"server=37.59.55.185;user=MCa5jNxFbz;password=oOrPyOCyBq;database=MCa5jNxFbz;" // беплатная удалённая бд 2
                //"server=25.36.221.15;user=application2;password=Qwerty_1;database=zq73krwnc8;" // пк
                //"server=25.17.110.171;user=application2;password=Qwerty_1;database=zq73krwnc8;" // ноут
                //"server=25.17.110.171;user=application2;password=Qwerty_1;database=test_long_db;" // ноут test long db
                "server=25.17.110.171;user=application2;password=Qwerty_1;database=generating_db;" // ноут test long db
            );
        }

    }
}
