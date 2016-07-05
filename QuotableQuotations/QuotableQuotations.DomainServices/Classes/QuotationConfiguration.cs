using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using QuotableQuotations.Core.Classes;

namespace QuotableQuotations.DomainServices.Classes
{
    public class QuotationConfiguration : EntityTypeConfiguration<Quotation>
    {
        public QuotationConfiguration()
        {
            ToTable("quotes", "dbo");

            //HasKey(e => e.Id);

            Property(e => e.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
            .HasColumnName("Quote_ID");

            Property(e => e.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();

            Property(e => e.Category).HasColumnName("Quote_Category").HasMaxLength(50);

            Property(e => e.Quote).HasColumnName("Quote");

        }
    }
}
