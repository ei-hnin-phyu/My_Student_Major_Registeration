using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class QSSDBContext : DbContext
    {
        public QSSDBContext(DbContextOptions options) : base(options) { }
        public QSSDBContext() { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Major> Major { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Name= "Mg Mg",Dob="14/1/2000",Email="mgmg@gmail.com",Major="Science",Nrc="14/PATANA(N)121222"},
                new Student { Name = "Su Su", Dob = "14/1/2000", Email = "susu@gmail.com", Major = "History", Nrc = "14/PATANA(N)111111" },
                new Student { Name = "Hla Hla", Dob = "14/1/2000", Email = "hlahla@gmail.com", Major = "History", Nrc = "14/PATANA(N)335556" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
