using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRCMS.Data;


namespace HRCMS.DBContext
{
    public class  CaseManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<HRCase> Hrcases { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<CaseSubType> CaseSubTypes { get; set; }
    }
}
