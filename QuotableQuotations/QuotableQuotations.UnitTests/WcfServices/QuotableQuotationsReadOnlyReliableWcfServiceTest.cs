using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NUnit.Framework;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Contracts.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.Services.Classes;
using Rhino.Mocks;

namespace QuotableQuotations.UnitTests.WcfServices
{
    [TestFixture]
    public class QuotableQuotationsReadOnlyReliableWcfServiceTest
    {
        private IQuotationService _myService;
        private IQuotableQuotationsReadOnlyReliableWcfService _wcfService;

        private List<Quotation> _quotations = new List<Quotation>();
        private Quotation _quotation1;
        private Quotation _quotation2;

        [SetUp]
        public void SetUp()
        {
            _myService = MockRepository.GenerateMock<IQuotationService>();
            _wcfService = new QuotableQuotationsReadOnlyReliableWcfService(_myService);
            SetupQuotations();
        }

        [Test]
        public void ShouldGetQuotationsByQuoteStrings()
        {
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything))
                .Return(_quotations);
            var quotableQuotations = _wcfService.GetQuotationsByQuoteStrings(new List<string> {"Art", "Technology"});

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
        public void ShouldGetQuotationsByNames()
        {
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything))
                .Return(_quotations);
            var quotableQuotations = _wcfService.GetQuotationsByNames(new List<string> { "Jon Doe", "Alice" });

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
        public void ShouldGetQuotationsByCategories()
        {
            _myService.Expect(ms => ms.GetMyEntities(Arg<Expression<Func<Quotation, bool>>>.Is.Anything))
                .Return(_quotations);
            var quotableQuotations = _wcfService.GetQuotationsByCategories(new List<string> { "Science", "Technology" });

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
