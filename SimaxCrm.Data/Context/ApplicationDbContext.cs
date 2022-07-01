using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimaxCrm.Model.Entity;

namespace SimaxCrm.Data.Context
{
    public class ApplicationDbContext
    : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
    ApplicationUserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<TeamSlug> TeamSlug { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<LeadLanguage> LeadLanguage { get; set; }
        public DbSet<LeadSource> LeadSource { get; set; }
        public DbSet<LeadTag> LeadTag { get; set; }
        public DbSet<LeadTagMapping> LeadTagMapping { get; set; }
        public DbSet<LeadRemarks> LeadRemarks { get; set; }
        public DbSet<CallLog> CallLog { get; set; }
        public DbSet<UserLog> UserLog { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<EmailSetup> EmailSetup { get; set; }
        public DbSet<LeadAutoAssign> LeadAutoAssign { get; set; }
        public DbSet<LeadAutoAssignSourceMapping> LeadAutoAssignSourceMapping { get; set; }
        public DbSet<LeadAutoAssignLog> LeadAutoAssignLog { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public DbSet<SystemSetup> SystemSetup { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            builder.Entity<LeadAutoAssignLog>()
              .HasOne(u => u.LeadSource)
              .WithMany(u => u.LeadAutoAssignLog).IsRequired()
              .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
