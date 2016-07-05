using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NUnit.Framework;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Contracts.Classes;
using QuotableQuotations.Contracts.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.Services.Classes;
using QuotableQuotations.Services.Mappers;
using Rhino.Mocks;

namespace QuotableQuotations.UnitTests.WcfServices
{
    [TestFixture]
    public class QuotableQuotationsWcfServiceTest
    {
        private IQuotationService _myService;
        private IQuotableQuotationsWcfService _wcfService;
        private List<Quotation> _quotations = new List<Quotation>();
        private Quotation _quotation1;
        private Quotation _quotation2;
        private List<Quotation> _quotations1;

        [SetUp]
        public void SetUp()
        {
            _myService = MockRepository.GenerateMock<IQuotationService>();
            _wcfService = new QuotableQuotationsWcfService(_myService);
            SetupQuotations();
        }

        [Test]
        public void ShouldGetAllQuotations()
        {
            _myService.Expect(ms => ms.GetAllMyEntities()).Return(_quotations);
            var quotableQuotations = _wcfService.GetAllQuotations();

            Assert.IsNotNull(quotableQuotations);
            _myService.VerifyAllExpectations();

            Assert.AreEqual(_quotations.Count, quotableQuotations.Count);

            Assert.AreEqual(_quotations[0].Id, quotableQuotations[0].Id);
            Assert.AreEqual(_quotations[0].Name, quotableQuotations[0].Name);
            Assert.AreEqual(_quotations[0].Category, quotableQuotations[0].Category);
            Assert.AreEqual(_quotations[0].Quote, quotableQuotations[0].Quote);

            Assert.AreEqual(_quotations[1].Id, quotableQuotations[1].Id);
            Assert.AreEqual(_quotations[1].Name, quotableQuotations[1].Name);
            Assert.AreEqual(_quotations[1].Category, quotableQuotations[1].Category);
            Assert.AreEqual(_quotations[1].Quote, quotableQuotations[1].Quote);
        }

        [Test]
        public void ShouldGetQuotations()
        {
            _quotations1 = new List<Quotation> { _quotation1};
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations1);
            var quotableQuotations = _wcfService.GetQuotations("Engineering");

            Assert.IsNotNull(quotableQuotations);
            _myService.VerifyAllExpectations();

            Assert.AreEqual(_quotations1.Count, quotableQuotations.Count);

            Assert.AreEqual(_quotations1[0].Id, quotableQuotations[0].Id);
            Assert.AreEqual(_quotations1[0].Name, quotableQuotations[0].Name);
            Assert.AreEqual(_quotations1[0].Category, quotableQuotations[0].Category);
            Assert.AreEqual(_quotations1[0].Quote, quotableQuotations[0].Quote);
        }

        [Test]
        public void ShouldGetQuotationsByName()
        {
            _quotations1 = new List<Quotation> { _quotation1 };
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations1);
            var quotableQuotations = _wcfService.GetQuotationsByName("Jon Doe");

            Assert.IsNotNull(quotableQuotations);
            _myService.VerifyAllExpectations();

            Assert.AreEqual(_quotations1.Count, quotableQuotations.Count);

            Assert.AreEqual(_quotations1[0].Id, quotableQuotations[0].Id);
            Assert.AreEqual(_quotations1[0].Name, quotableQuotations[0].Name);
            Assert.AreEqual(_quotations1[0].Category, quotableQuotations[0].Category);
            Assert.AreEqual(_quotations1[0].Quote, quotableQuotations[0].Quote);
        }

        [Test]
        public void ShouldGetQuotationsByCategory()
        {
            _quotations1 = new List<Quotation> { _quotation1 };
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations1);
            var quotableQuotations = _wcfService.GetQuotationsByCategory("Science");

            Assert.IsNotNull(quotableQuotations);
            _myService.VerifyAllExpectations();

            Assert.AreEqual(_quotations1.Count, quotableQuotations.Count);

            Assert.AreEqual(_quotations1[0].Id, quotableQuotations[0].Id);
            Assert.AreEqual(_quotations1[0].Name, quotableQuotations[0].Name);
            Assert.AreEqual(_quotations1[0].Category, quotableQuotations[0].Category);
            Assert.AreEqual(_quotations1[0].Quote, quotableQuotations[0].Quote);
        }

        [Test]
        public void ShouldCreateQuotation()
        {
            var contractQuotation1 = new QuotableQuotation
            {
                Name = _quotation1.Name,
                Category = _quotation1.Category,
                Quote = _quotation1.Quote
            };
            _myService.Expect(ms => ms.CreateMyEntity(Arg<Quotation>.Is.Anything));
            _wcfService.CreateQuotation(contractQuotation1);

           _myService.VerifyAllExpectations();
        }

        [Test]
        public void ShouldUpdateQuotation()
        {
            _quotations1 = new List<Quotation> { _quotation1 };
            var contractQuotation1 = new QuotableQuotation
            {
                Name = _quotation1.Name,
                Category = _quotation1.Category,
                Quote = _quotation1.Quote
            };

            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations1);
            _myService.Expect(ms => ms.UpdateMyEntity(Arg<Quotation>.Is.Anything));
            _wcfService.UpdateQuotation(1, contractQuotation1);

            _myService.VerifyAllExpectations();
        }

        [Test]
        public void ShouldDeleteQuotation()
        {
            _quotations1 = new List<Quotation> { _quotation1 };
            var contractQuotation1 = new QuotableQuotation
            {
                Name = _quotation1.Name,
                Category = _quotation1.Category,
                Quote = _quotation1.Quote
            };

            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(_quotations1);
            _myService.Expect(ms => ms.DeleteMyEntity(Arg<Quotation>.Is.Anything));
            _wcfService.DeleteQuotation(1);

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
        }
    }
}
