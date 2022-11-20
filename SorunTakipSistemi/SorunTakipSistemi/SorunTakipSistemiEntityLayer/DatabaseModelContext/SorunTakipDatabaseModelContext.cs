using Microsoft.EntityFrameworkCore;
using SorunTakipSistemiEntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorunTakipSistemiEntityLayer.DatabaseModelContext
{
    public class SorunTakipDatabaseModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=89.252.181.210\MSSQLSERVER2014;Database=mekacom_SorunTakip;User ID=mekacom_SorunTakipAdmin;Password=_Fd45ki57;Trusted_Connection=false;");
        }
        public DbSet<ProblemTracking> ProblemTrackings { get; set; }
        public DbSet<ProblemTrackingComment> ProblemTrackingComments { get; set; }
        public DbSet<UserMember> UserMembers { get; set; }
        public DbSet<UserMemberRole> UserMemberRoles { get; set; }
    }
}
