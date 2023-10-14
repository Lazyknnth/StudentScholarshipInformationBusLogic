using Microsoft.EntityFrameworkCore;
using StudentScholarshipInformationBusLogic.context.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScholarshipInformationBusLogic.context
{
    public class StudentScholarshipInformationDBContext:DbContext
    {
        public DbSet<StudentTable> StudentTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-M1BPO28;Database=StudentScholarshipInformationDB;Trusted_Connection=True;TrustServerCertificate=True; Encrypt=false;");
        }
    }
}
