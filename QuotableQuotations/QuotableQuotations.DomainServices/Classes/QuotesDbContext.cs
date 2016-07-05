using System.Data.Entity;
using QuotableQuotations.Core.Classes;

namespace QuotableQuotations.DomainServices.Classes
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext()
            : base("QuotationConnectionString")
        {
            Database.SetInitializer<QuotesDbContext>(new CreateDatabaseIfNotExists<QuotesDbContext>());
        }

        public DbSet<Quotation> Quotations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add<Quotation>(new QuotationConfiguration());
        }
    }
}
