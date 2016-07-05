using System.Collections.Generic;
using NUnit.Framework;
using QuotableQuotations.Contracts.Classes;
using QuotableQuotations.Core.Classes;
using QuotableQuotations.Services.Mappers;

namespace QuotableQuotations.UnitTests.Mappers
{
    [TestFixture]
    public class QuotableQuotationsMapperTest
    {
        private List<Quotation> _quotations = new List<Quotation>();
        private QuotableQuotation _quotableQuotation;

        [SetUp]
        public void SetUp()
        {
            SetupQuotations();
            SetupQuotableQuotation();
        }

        private void SetupQuotableQuotation()
        {
            _quotableQuotation = new QuotableQuotation
            {
               Id=1,
               Name="Bob",
               Category = "Computers",
               Quote = "What is the mass of software? asked the Computer Scientist to the Physicist."
            };
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
                Id = 1,
                Category = "Technology",
                Name = "Alice",
                Quote = "Technology should inspire us, not intimdate us."
            };
            _quotations.Add(quotation1);
            _quotations.Add(quotation2);
        }

        [Test]
        public void ShouldMapListOfQuotationsToQuotableQuotations()
        {
            var quotableQuotations = QuotableQuotationsMapper.MapToQuotableQuotations(_quotations);

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
        public void ShouldMapQuotableQuotationToQuotation()
        {
            var quotation = QuotableQuotationsMapper.MapToQuotation(_quotableQuotation);

            Assert.IsNotNull(quotation);

            Assert.AreEqual(quotation.Id, _quotableQuotation.Id);
            Assert.AreEqual(quotation.Name, _quotableQuotation.Name);
            Assert.AreEqual(quotation.Category, _quotableQuotation.Category);
            Assert.AreEqual(quotation.Quote, _quotableQuotation.Quote);
        }
    }
}
