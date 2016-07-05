using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using QuotableQuotations.ApplicationServices.Classes;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Contracts.Classes;
using QuotableQuotations.Contracts.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.DomainServices.Classes;
using QuotableQuotations.Services.Mappers;

namespace QuotableQuotations.Services.Classes
{
    public class QuotableQuotationsReadOnlyReliableWcfService: IQuotableQuotationsReadOnlyReliableWcfService
    {
        private readonly IQuotationService _myService;

        public QuotableQuotationsReadOnlyReliableWcfService() : this(new QuotationService(new GenericRepository<Quotation>(new QuotesDbContext())))
        {
                
        }

        public QuotableQuotationsReadOnlyReliableWcfService(IQuotationService myService)
        {
            _myService = myService;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public List<QuotableQuotation> GetQuotationsByQuoteStrings(List<string> quoteTexts)
        {
            List<QuotableQuotation> quotes = new List<QuotableQuotation>();
            quoteTexts.ForEach(qt =>
            {
                quotes.AddRange(QuotableQuotationsMapper.MapToQuotableQuotations(
                    _myService.GetMyEntities(q => q.Quote.Contains(qt)).ToList()));
            });
            return quotes.GroupBy(q => q.Id).Select(g => g.First()).ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public List<QuotableQuotation> GetQuotationsByNames(List<string> names)
        {
            List<QuotableQuotation> quotes = new List<QuotableQuotation>();
            names.ForEach(qn =>
            {
                quotes.AddRange(QuotableQuotationsMapper.MapToQuotableQuotations(
                    _myService.GetMyEntities(q => q.Name.Contains(qn)).ToList()));
            });
            return quotes.GroupBy(q => q.Id).Select(g => g.First()).ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public List<QuotableQuotation> GetQuotationsByCategories(List<string> categories)
        {
            List<QuotableQuotation> quotes = new List<QuotableQuotation>();
            categories.ForEach(qc =>
            {
                quotes.AddRange(QuotableQuotationsMapper.MapToQuotableQuotations(
                    _myService.GetMyEntities(q => q.Category.Equals(qc.Trim(), StringComparison.InvariantCultureIgnoreCase)).ToList()));
            });
            return quotes.GroupBy(q => q.Id).Select(g => g.First()).ToList();
        }
    }
}
