using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace tugbanınnesne.Models
{
    public class AppDbContext : DbContext
    {


        public DbSet<Student> Student { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Register> Register { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-AKKUFL1.\\;initial catalog=CBS03DB;user id=sa; password=123;TrustServerCertificate=True");
            
           
        }
    }
}
