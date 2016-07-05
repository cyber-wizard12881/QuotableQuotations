using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NUnit.Framework;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Contracts.Classes;
using QuotableQuotations.Contracts.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.Services.Classes;
using Rhino.Mocks;

namespace QuotableQuotations.UnitTests.WcfServices
{
    [TestFixture]
    public class QuotableQuotationsReliableWcfServiceTest
    {
        private IQuotationService _myService;
        private IQuotableQuotationsReliableWcfService _wcfService;

        private List<Quotation> _quotations = new List<Quotation>();
        private Quotation _quotation1;
        private Quotation _quotation2;
        private Quotation _quotation;
        private List<QuotableQuotation> _quotations1 = new List<QuotableQuotation>();

        [SetUp]
        public void SetUp()
        {
            _myService = MockRepository.GenerateMock<IQuotationService>();
            _wcfService = new QuotableQuotationsReliableWcfService(_myService);
            SetupQuotations();
        }

        [Test]
        public void ShouldInsertQuotations()
        {
            _quotations1.Add(new QuotableQuotation
            {
                Id = _quotation.Id,
                Name = _quotation.Name,
                Category = _quotation.Category,
                Quote = _quotation.Quote
            });

            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(new List<Quotation>());
            _myService.Expect(ms => ms.CreateMyEntity(Arg<Quotation>.Is.Anything));

            _wcfService.UpdateOrInsertQuotations(_quotations1);

            _myService.VerifyAllExpectations();
        }

        [Test]
        public void ShouldUpdateQuotations()
        {
            _quotations1.Add(new QuotableQuotation
            {
                Id = _quotation1.Id,
                Name = _quotation1.Name,
                Category = _quotation1.Category,
                Quote = _quotation.Quote
            });
            _quotations1.Add(new QuotableQuotation
            {
                Id = _quotation2.Id,
                Name = _quotation2.Name,
                Category = _quotation.Category,
                Quote = _quotation2.Quote
            });

            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations);
            _myService.Expect(ms => ms.UpdateMyEntity(Arg<Quotation>.Is.Anything));

            _wcfService.UpdateOrInsertQuotations(_quotations1);

            _myService.VerifyAllExpectations();
        }

        [Test]
        public void ShouldDeleteQuotations()
        {
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations);
            _myService.Expect(ms => ms.DeleteMyEntity(Arg<Quotation>.Is.Anything));

            _wcfService.DeleteQuotations(new List<int> { _quotation1.Id, _quotation2.Id });

            _myService.VerifyAllExpectations();
        }

        private void SetupQuotations()
        {
            _quotations.Clear();

            _quotation1 = new Quotation
            {
                Id = 1,
                Category = "Science",
                Name = "Jon Doe",
                Quote = "When Art meets Science, Engineering is born, when it matures it is called Technology."
            };

            _quotation2 = new Quotation
            {
                Id = 2,
                Category = "Technology",
                Name = "Alice",
                Quote = "Technology should inspire us, not intimidate us."
            };
            _quotations.Add(_quotation1);
            _quotations.Add(_quotation2);

            _quotation = new Quotation
            {
                Id = 3,
                Category = "Science",
                Name = "Jon Doe",
                Quote = "When Art meets Science, Engineering is born, when it matures it is called Technology."
            };
        }
    }
}
