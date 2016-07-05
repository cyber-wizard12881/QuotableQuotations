using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using QuotableQuotations.Contracts.Classes;

namespace QuotableQuotations.Contracts.Interfaces
{
    [ServiceContract]
    public interface IQuotableQuotationsReliableWcfService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateOrInsertQuotations(List<QuotableQuotation> quotableQuotations);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void DeleteQuotations(List<int> ids);
    }
}
