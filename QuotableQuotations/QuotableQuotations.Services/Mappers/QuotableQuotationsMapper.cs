using System.Collections.Generic;
using QuotableQuotations.Contracts.Classes;
using QuotableQuotations.Core.Classes;

namespace QuotableQuotations.Services.Mappers
{
    public static class QuotableQuotationsMapper
    {
        public static List<QuotableQuotation> MapToQuotableQuotations(List<Quotation> domainList)
        {
            List<QuotableQuotation> contractList = new List<QuotableQuotation>();
            domainList.ForEach(dl =>
            {
                contractList.Add(new QuotableQuotation
                {
                    Id = dl.Id,
                    Name = dl.Name,
                    Category = dl.Category,
                    Quote = dl.Quote
                });
            });
            return contractList;
        }

        public static Quotation MapToQuotation(QuotableQuotation contractQuotation)
        {
            return new Quotation
            {
                Id = contractQuotation.Id,
                Name = contractQuotation.Name,
                Category = contractQuotation.Category,
                Quote = contractQuotation.Quote
            };
        }
    }
}
