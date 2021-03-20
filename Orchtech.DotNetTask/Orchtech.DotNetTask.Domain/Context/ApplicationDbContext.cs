using Microsoft.EntityFrameworkCore;
using Orchtech.DotNetTask.Domain.Entities;

namespace Orchtech.DotNetTask.Domain
{

    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        #region DbSets

        public DbSet<Class> Classs { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Student> Students { get; set; }

        #endregion DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}