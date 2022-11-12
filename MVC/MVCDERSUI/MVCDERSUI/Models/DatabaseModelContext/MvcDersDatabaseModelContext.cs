﻿using Microsoft.EntityFrameworkCore;
using MVCDERSUI.Models.Entity;

namespace MVCDERSUI.Models.DatabaseModelContext
{
    public class MvcDersDatabaseModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SOFTWARE\SQLEXPRESS;Database=MvcDers;Integrated Security=True;");
            //optionsBuilder.UseSqlServer(@"Server=SOFTWARE\SQLEXPRESS; Database=MvcDers");
        }
        public DbSet<UserMember> UserMembers { get; set; }
    }
}
