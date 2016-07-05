using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NUnit.Framework;
using QuotableQuotations.ApplicationServices.Classes;
using QuotableQuotations.ApplicationServices.Interfaces;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.DomainServices.Interfaces;
using Rhino.Mocks;

namespace QuotableQuotations.UnitTests.ApplicationServices
{
    [TestFixture]
    public class QuotationServiceTest
    {
        private IGenericRepository<Quotation> _myEntityRepository;
        private IQuotationService _quotationService;
        private Quotation _quotation;
        private List<Quotation> _quotations = new List<Quotation>();

        [SetUp]
        public void SetUp()
        {
            _myEntityRepository = MockRepository.GenerateMock<IGenericRepository<Quotation>>();
            _quotationService = new QuotationService(_myEntityRepository);
            _quotation = new Quotation
            {
                Id = 1,
                Category = "Science",
                Name = "Jon Doe",
                Quote = "When Art meets Science, Engineering is born, when it matures it is called Technology."
            };
            SetupQuotations();
        }

        [Test]
        public void ShouldCreateMyEntity()
        {
            _myEntityRepository.Expect(mer => mer.Add(Arg<Quotation>.Matches(q => AreEqual(q, _quotation))));
            _quotationService.CreateMyEntity(_quotation);

            _myEntityRepository.VerifyAllExpectations();
        }

        [Test]
        public void ShouldGetAllMyEntities()
        {
            _myEntityRepository.Expect(mer => mer.GetAll()).Return(_quotations.AsQueryable());
            var quotableQuotations = _quotationService.GetAllMyEntities().ToList();

            _myEntityRepository.VerifyAllExpectations();
            Assert.IsNotNull(quotableQuotations);

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
        public void ShouldGetMyEntities()
        {
            var quotations = new List<Quotation> {_quotation};

            _myEntityRepository.Expect(mer => mer.FindBy(Arg<Expression<Func<Quotation, bool>>>.Is.Anything)).Return(quotations.AsQueryable());
            var quotableQuotations = _quotationService.GetMyEntities(q => q.Category.Equals("Technology")).ToList();

            _myEntityRepository.VerifyAllExpectations();
            Assert.IsNotNull(quotableQuotations);

            Assert.AreEqual(quotations.Count, quotableQuotations.Count);

            Assert.AreEqual(quotations[0].Id, quotableQuotations[0].Id);
            Assert.AreEqual(quotations[0].Name, quotableQuotations[0].Name);
            Assert.AreEqual(quotations[0].Category, quotableQuotations[0].Category);
            Assert.AreEqual(quotations[0].Quote, quotableQuotations[0].Quote);

        }

        [Test]
        public void ShouldUpdateMyEntity()
        {
            _myEntityRepository.Expect(mer => mer.Edit(Arg<Quotation>.Matches(q => AreEqual(q, _quotation))));
            _quotationService.UpdateMyEntity(_quotation);

            _myEntityRepository.VerifyAllExpectations();
        }

        [Test]
        public void ShouldDeleteMyEntity()
        {
            _myEntityRepository.Expect(mer => mer.Delete(Arg<Quotation>.Matches(q => AreEqual(q, _quotation))));
            _quotationService.DeleteMyEntity(_quotation);

            _myEntityRepository.VerifyAllExpectations();
        }

        private bool AreEqual(Quotation quotation1, Quotation quotation2)
        {
            return quotation1.Id == quotation2.Id && quotation1.Name.Equals(quotation2.Name) &&
                   quotation1.Category.Equals(quotation2.Category) && quotation1.Quote.Equals(quotation2.Quote);
        }

        private void SetupQuotations()
        {
            var quotation1 = new Quotation
            {
                Id = 1,
                Category = "Science",
                Name = "Jon Doe",
                Quote = "When Art meets Science, Engineering is born, when it matures it is called Technology."
            };

            var quotation2 = new Quotation
            {
                Id = 2,
                Category = "Technology",
                Name = "Alice",
                Quote = "Technology should inspire us, not intimidate us."
            };
            _quotations.Add(quotation1);
            _quotations.Add(quotation2);
        }
    }
}
