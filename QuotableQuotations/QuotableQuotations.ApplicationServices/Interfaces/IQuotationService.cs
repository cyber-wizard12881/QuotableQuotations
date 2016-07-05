using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using QuotableQuotations.Core.Classes;

namespace QuotableQuotations.ApplicationServices.Interfaces
{
    public interface IQuotationService
    {
            void CreateMyEntity(Quotation myEntity);
            IEnumerable<Quotation> GetMyEntities(Expression<Func<Quotation, bool>> predicate);
            IEnumerable<Quotation> GetAllMyEntities();
            void UpdateMyEntity(Quotation myEntity);
            void DeleteMyEntity(Quotation myEntity);
            
    }
}
