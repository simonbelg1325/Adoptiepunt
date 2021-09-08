using Adoptiepunt.Service.Actions;
using Microsoft.EntityFrameworkCore;
using Vidyano.Service;

namespace Adoptiepunt.Service
{
    public partial class AdoptiepuntContext : TargetDbContext
    {
        public AdoptiepuntContext(DbContextOptions<AdoptiepuntContext> options)
            : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<ContactVia> ContactVias { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<RegistrationTag> RegistrationTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<RelationType> RelationTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PersonCategory> PersonCategories { get; set; }
        public DbSet<CountryOfOrigin> CountryOfOrigins { get; set; }
        public DbSet<PersonCountryOfOrigin> PersonCountryOfOrigins { get; set; }
        public DbSet<InvitationPurpose> InvitationPurposes { get; set; }
        public DbSet<PersonInvitationPurpose> PersonInvitationPurposes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relation>()
                .HasOne(r => r.Person)
                .WithMany(p => p.Relations)
                .HasForeignKey(r => r.ParentPersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .IsRequired();

            modelBuilder.Entity<Relation>()
               .HasOne(r => r.Person)
               .WithMany(p => p.Relations)
               .HasForeignKey(r => r.ChildPersonId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
