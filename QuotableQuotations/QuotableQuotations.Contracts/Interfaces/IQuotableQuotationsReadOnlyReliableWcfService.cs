using System.Collections.Generic;
using System.ServiceModel;
using QuotableQuotations.Contracts.Classes;

namespace QuotableQuotations.Contracts.Interfaces
{
    [ServiceContract]
    public interface IQuotableQuotationsReadOnlyReliableWcfService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        List<QuotableQuotation> GetQuotationsByQuoteStrings(List<string> quoteTexts);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        List<QuotableQuotation> GetQuotationsByNames(List<string> names);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        List<QuotableQuotation> GetQuotationsByCategories(List<string> categories);
    }
}
