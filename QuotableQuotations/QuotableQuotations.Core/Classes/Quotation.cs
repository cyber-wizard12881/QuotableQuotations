using QuotableQuotations.Core.Interfaces;

namespace QuotableQuotations.Core.Classes
{
    public class Quotation : IQuotation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Quote { get; set; }
    }
}
