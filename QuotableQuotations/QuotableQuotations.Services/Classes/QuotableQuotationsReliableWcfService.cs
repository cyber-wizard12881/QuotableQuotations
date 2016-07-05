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
    public class QuotableQuotationsReliableWcfService: IQuotableQuotationsReliableWcfService
    {
        private readonly IQuotationService _myService;

        public QuotableQuotationsReliableWcfService() : this(new QuotationService(new GenericRepository<Quotation>(new QuotesDbContext())))
        {
                
        }

        public QuotableQuotationsReliableWcfService(IQuotationService myService)
        {
            _myService = myService;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateOrInsertQuotations(List<QuotableQuotation> quotableQuotations)
        {
            quotableQuotations.ForEach(qq =>
            {
                Quotation quotation = _myService.GetMyEntities(q => q.Id == qq.Id).FirstOrDefault();

                if (quotation != null)
                {
                    quotation.Category = !string.IsNullOrWhiteSpace(qq.Category) ? qq.Category : quotation.Category;
                    quotation.Name = !string.IsNullOrWhiteSpace(qq.Name) ? qq.Name : quotation.Name;
                    quotation.Quote = !string.IsNullOrWhiteSpace(qq.Quote) ? qq.Quote : quotation.Quote;
                    _myService.UpdateMyEntity(quotation);
                }
                else
                {
                    qq.Id = 0;
                    _myService.CreateMyEntity(QuotableQuotationsMapper.MapToQuotation(qq));
                }
            });
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void DeleteQuotations(List<int> ids)
        {
            ids.ForEach(id =>
            {
                Quotation quotation = _myService.GetMyEntities(q => q.Id == id).FirstOrDefault();
                if (quotation != null)
                    _myService.DeleteMyEntity(quotation);
            });
        }
    }
}
