/* Coder by KFY */
using System.Data.Entity;
using CarWashingAutomation.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Windows.Forms;

namespace CarWashingAutomation.Components
{
    public class CarWashingDbContext : DbContext
    {
        public CarWashingDbContext() : base()
        {
            this.Database.Connection.ConnectionString = "Data Source=" + Application.StartupPath.ToString() + @"\" + Constants.DB_ConnectionString;
            Database.SetInitializer<CarWashingDbContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineAlarm> MachineAlarms { get; set; }
        public DbSet<MachineReport> MachineReports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
