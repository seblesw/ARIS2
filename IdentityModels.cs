using ARIS.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
namespace ARIS.Infrastructor
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("Resident")]
        public Guid? ResidentId { get; set; }
        [ForeignKey("User")]
        public Guid? UserrId { get; set; }
        public string UmaUla { get; set; }
        public virtual Resident Resident { get; set; }
        public virtual Userr User { get; set; }
    }
    public class DataSource : IdentityDbContext<ApplicationUser>
    {
        public DataSource() : base("ARISDbConnection") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<IdentityUser>().ToTable("User");
            modelBuilder.Entity<ApplicationUser>().ToTable("UserProfile");
            modelBuilder.Entity<IdentityRole>().ToTable("Role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserInRole");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
        }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Userr> Userres { get; set; }
        public DbSet<VitalEvent> VitalEvents { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BirthCertefcate> BirthCertefcates { get; set; }
        public DbSet<DeathCerteficate> DeathCerteficates { get; set; }
        public DbSet<MarrageCerteficate> MarrageCerteficate { get; set; }
        public DbSet<NewResident> NewResident { get; set; }
    }
    public class IdentityManager
    {
        public bool RoleExists(string name)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new DataSource()));
            return rm.RoleExists(name);
        }

        public bool CreateRole(string name)
        {
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new DataSource()));
            var idResult = rm.Create(new IdentityRole(name));
            return idResult.Succeeded;
        }
        public bool CreateUser(ApplicationUser user, string password)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DataSource()));
            var idResult = um.Create(user, password);
            return idResult.Succeeded;
        }
        public bool AddUserToRole(string userId, string roleName)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DataSource()));
            var idResult = um.AddToRole(userId, roleName);
            return idResult.Succeeded;
        }
        public void ClearUserRoles(string userId)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DataSource()));
            var roles = um.GetRoles(userId).ToList();
            if (roles.Count > 0)
            {
                foreach (var r in roles)
                {
                    um.RemoveFromRole(userId, r);
                }
            }
            um.Dispose();
        }
        public void RemoveUser(string userId)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DataSource()));
            var user = um.FindById(userId);
            if (user != null)
            {
                var roles = um.GetRoles(userId).ToList();
                if (roles.Count > 0)
                {
                    foreach (var r in roles)
                    {
                        um.RemoveFromRole(userId, r);
                    }
                }
                um.Delete(user);
            }
            um.Dispose();
        }
        public bool UserByName(string userName)
        {
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new DataSource()));
            var user = um.FindByName(userName);
            var rslt = user != null;
            um.Dispose();
            return rslt;
        }
    }
}