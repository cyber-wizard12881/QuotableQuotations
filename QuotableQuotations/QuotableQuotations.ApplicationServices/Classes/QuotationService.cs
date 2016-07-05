using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.DomainServices.Interfaces;

namespace QuotableQuotations.ApplicationServices.Classes
{
    public class QuotationService : IQuotationService
    {
        private readonly IGenericRepository<Quotation> _myEntityRepository;

        public QuotationService(IGenericRepository<Quotation> myEntityRepository)
        {
            this._myEntityRepository = myEntityRepository;
        }

        public void CreateMyEntity(Quotation myEntity)
        {
            this._myEntityRepository.Add(myEntity);
        }

        public IEnumerable<Quotation> GetMyEntities(Expression<Func<Quotation, bool>> predicate)
        {
            return this._myEntityRepository.FindBy(predicate);
        }

        public IEnumerable<Quotation> GetAllMyEntities()
        {
            return this._myEntityRepository.GetAll();
        }

        public void UpdateMyEntity(Quotation myEntity)
        {
            this._myEntityRepository.Edit(myEntity);
        }

        public void DeleteMyEntity(Quotation myEntity)
        {
            this._myEntityRepository.Delete(myEntity);
        }
    }
}
