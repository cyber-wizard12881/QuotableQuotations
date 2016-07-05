using System;
using System.Collections.Generic;
using System.Linq;
using QuotableQuotations.ApplicationServices.Classes;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Contracts.Classes;
using QuotableQuotations.Contracts.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.DomainServices.Classes;
using QuotableQuotations.Services.Mappers;

namespace QuotableQuotations.Services.Classes
{
    public class QuotableQuotationsWcfService: IQuotableQuotationsWcfService
    {
        private readonly IQuotationService _myService;

        public QuotableQuotationsWcfService():this(new QuotationService(new GenericRepository<Quotation>(new QuotesDbContext())))
        {
                
        }

        public QuotableQuotationsWcfService(IQuotationService myService)
        {
            _myService = myService;
        }

        public List<QuotableQuotation> GetAllQuotations()
        {
            return QuotableQuotationsMapper.MapToQuotableQuotations(_myService.GetAllMyEntities().ToList());
        }

        public List<QuotableQuotation> GetQuotations(string text)
        {
            return QuotableQuotationsMapper.MapToQuotableQuotations(_myService.GetMyEntities(q => q.Quote.Contains(text)).ToList());
        }

        public List<QuotableQuotation> GetQuotationsByCategory(string category)
        {
            return QuotableQuotationsMapper.MapToQuotableQuotations(_myService.GetMyEntities(q => q.Category.Equals(category.Trim(), StringComparison.InvariantCultureIgnoreCase)).ToList());
        }

        public List<QuotableQuotation> GetQuotationsByName(string name)
        {
            return QuotableQuotationsMapper.MapToQuotableQuotations(_myService.GetMyEntities(q => q.Name.Contains(name)).ToList());
        }

        public void CreateQuotation(QuotableQuotation quote)
        {
            quote.Id = 0;
            _myService.CreateMyEntity(QuotableQuotationsMapper.MapToQuotation(quote));
        }

        public void UpdateQuotation(int id, QuotableQuotation quote)
        {
            Quotation quotation = _myService.GetMyEntities(q => q.Id == id).FirstOrDefault();

            if (quotation != null)
            {
                quotation.Category = !string.IsNullOrWhiteSpace(quote.Category)? quote.Category: quotation.Category;
                quotation.Name = !string.IsNullOrWhiteSpace(quote.Name) ? quote.Name : quotation.Name;
                quotation.Quote = !string.IsNullOrWhiteSpace(quote.Quote) ? quote.Quote : quotation.Quote;
                _myService.UpdateMyEntity(quotation);
            }
        }

        public void DeleteQuotation(int id)
        {
            Quotation quotation = _myService.GetMyEntities(q => q.Id == id).FirstOrDefault();
            if (quotation != null)
                _myService.DeleteMyEntity(quotation);
        }
    }
}
