using Api.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.ModelContext
{
    public class HotelDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=89.252.181.210\MSSQLSERVER2014;Database=mekacom_Api;User ID=mekacom_Api-Admin;Password=1d?y46N6j;Trusted_Connection=False;");
        }

        public virtual DbSet<Hotel> Hotels { get; set; }
    }
}
