using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BrainWork.ATM.Data
{
    public class ATMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-4QP868O\\SQLEXPRESS;Initial Catalog=BrainWork;Integrated Security=True";

            OptionsBuilder.UseSqlServer(connectionString);
        }


    }
}
