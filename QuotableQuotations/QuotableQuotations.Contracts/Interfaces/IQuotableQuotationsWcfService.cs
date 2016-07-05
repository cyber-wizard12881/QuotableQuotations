using System.Collections.Generic;
using System.ServiceModel;
using QuotableQuotations.Contracts.Classes;

namespace QuotableQuotations.Contracts.Interfaces
{
    [ServiceContract]
    public interface IQuotableQuotationsWcfService
    {
        [OperationContract]
        List<QuotableQuotation> GetAllQuotations();

        [OperationContract]
        List<QuotableQuotation> GetQuotations(string text);

        [OperationContract]
        List<QuotableQuotation> GetQuotationsByCategory(string category);

        [OperationContract]
        List<QuotableQuotation> GetQuotationsByName(string name);

        [OperationContract]
        void CreateQuotation(QuotableQuotation quote);

        [OperationContract]
        void UpdateQuotation(int id, QuotableQuotation quote);

        [OperationContract]
        void DeleteQuotation(int id);
    }
}
