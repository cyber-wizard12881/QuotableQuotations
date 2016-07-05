using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using QuotableQuotations.Client.Properties;
using QuotableQuotations.Client.QuotableQuotationsWcfService;

namespace QuotableQuotations.Client
{
    public partial class QuotableQuotationsForm : Form
    {
        QuotableQuotationsWcfServiceClient wcfServiceClient = new QuotableQuotationsWcfServiceClient();
        public QuotableQuotationsForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbNonTransactional.Checked)
                ProcessNonTransactionalOperations();
            else if (rbTransactional.Checked)
                ProcessTransactionalOperations();
        }

        private void ProcessTransactionalOperations()
        {
            if (rbReplace.Checked)
            {
                if (rbName.Checked)
                    ReplaceNamesOfQuotations();
                else if (rbCategory.Checked)
                    ReplaceCategoriesOfQuotations();
                else if (rbText.Checked)
                    ReplaceTextsOfQuotations();
            }
            else if (rbTransactionalDelete.Checked)
            {
                DeleteQuotations();
            }
            else if (rbTransactionalCreate.Checked)
            {
                CreateQuotations();
            }
        }

        private void DisplayTransactionalStatus(string message)
        {
            txtResult.Clear();
            txtResult.Text = message;
        }

        private void CreateQuotations()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient reliableWcfServiceClient =
                        new QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient();

                    var ids = txtQQId.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var names = txtQQName.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var categories = txtQQCategory.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var quotes = txtQQQuote.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    if (ids.Length != names.Length || names.Length != categories.Length ||
                        categories.Length != quotes.Length)
                    {
                        throw new Exception("Ids, Names, Categories & Quotes must have equal number entries!!");
                    }
                    
                    var idsToBeCreated = new int[ids.Length];
                    var quotableQuotationsToBeCreated = new QuotableQuotationsReliableWcfService.QuotableQuotation[ids.Length];

                    for (int idx = 0; idx < ids.Length; idx++)
                    {
                        idsToBeCreated[idx] = Convert.ToInt32(ids[idx]);
                        quotableQuotationsToBeCreated[idx] = new QuotableQuotationsReliableWcfService.QuotableQuotation
                        {
                            Id = idsToBeCreated[idx],
                            Name = names[idx],
                            Category = categories[idx],
                            Quote = quotes[idx]
                        };
                    }

                    reliableWcfServiceClient.UpdateOrInsertQuotations(quotableQuotationsToBeCreated);

                    ts.Complete();
                    DisplayTransactionalStatus("Quotations created successfully in Transactional Mode..!!!!");
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    DisplayTransactionalStatus("Quotations creation failed in Transactional Mode..!!!!");
                }
            }
        }

        private void DeleteQuotations()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient reliableWcfServiceClient =
                        new QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient();

                    var ids = txtQQId.Text.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
                    var idsToBeDeleted = new int[ids.Length];

                    for (int idx = 0; idx < ids.Length; idx++)
                    {
                     idsToBeDeleted[idx] = Convert.ToInt32(ids[idx]);
                    }

                    reliableWcfServiceClient.DeleteQuotations(idsToBeDeleted);

                    ts.Complete();
                    DisplayTransactionalStatus("Quotations deleted successfully in Transactional Mode..!!!!");
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    DisplayTransactionalStatus("Quotations deletion failed in Transactional Mode..!!!!");
                }
            }
        }

        private void ReplaceTextsOfQuotations()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotationsReadOnlyReliableWcfServiceClient
                        readOnlyReliableWcfServiceClient =
                            new QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotationsReadOnlyReliableWcfServiceClient();
                    QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient reliableWcfServiceClient =
                        new QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient();

                    var textsFrom = txtFrom.Text.Split(new[] { "," }, StringSplitOptions.None);
                    var textsTo = txtTo.Text.Split(new[] { "," }, StringSplitOptions.None);

                    if (textsFrom.Length != textsTo.Length)
                        throw new Exception("From & To parameters must have equal entries!!");

                    var quotableQuotationsFrom = readOnlyReliableWcfServiceClient.GetQuotationsByCategories(textsFrom);
                    var quotableQuotationsTo =
                        new QuotableQuotationsReliableWcfService.QuotableQuotation[quotableQuotationsFrom.Length];

                    for (int idx = 0; idx < quotableQuotationsFrom.Length; idx++)
                    {
                        var replacedQuote = quotableQuotationsFrom[idx].Quote.Replace(textsFrom[idx], textsTo[idx]);
                        quotableQuotationsTo[idx] = new QuotableQuotationsReliableWcfService.QuotableQuotation
                        {
                            Id = quotableQuotationsFrom[idx].Id,
                            Name = quotableQuotationsFrom[idx].Name,
                            Category = quotableQuotationsFrom[idx].Category,
                            Quote = replacedQuote
                        };
                    }

                    reliableWcfServiceClient.UpdateOrInsertQuotations(quotableQuotationsTo);

                    ts.Complete();
                    DisplayTransactionalStatus("Quotations replaced texts successfully in Transactional Mode..!!!!");
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    DisplayTransactionalStatus("Quotations replace texts failed in Transactional Mode..!!!!");
                }
            }
        }

        private void ReplaceCategoriesOfQuotations()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotationsReadOnlyReliableWcfServiceClient
                        readOnlyReliableWcfServiceClient =
                            new QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotationsReadOnlyReliableWcfServiceClient();
                    QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient reliableWcfServiceClient =
                        new QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient();

                    var categoriesFrom = txtFrom.Text.Split(new[] { "," }, StringSplitOptions.None);
                    var categoriesTo = txtTo.Text.Split(new[] { "," }, StringSplitOptions.None);

                    if (categoriesFrom.Length != categoriesTo.Length)
                        throw new Exception("From & To parameters must have equal entries!!");

                    var quotableQuotationsFrom = readOnlyReliableWcfServiceClient.GetQuotationsByCategories(categoriesFrom);
                    var quotableQuotationsTo =
                        new QuotableQuotationsReliableWcfService.QuotableQuotation[quotableQuotationsFrom.Length];

                    for (int idx = 0; idx < quotableQuotationsFrom.Length; idx++)
                    {
                        quotableQuotationsFrom[idx].Category = categoriesTo[idx];
                        quotableQuotationsTo[idx] = new QuotableQuotationsReliableWcfService.QuotableQuotation
                        {
                            Id = quotableQuotationsFrom[idx].Id,
                            Name = quotableQuotationsFrom[idx].Name,
                            Category = quotableQuotationsFrom[idx].Category,
                            Quote = quotableQuotationsFrom[idx].Quote
                        };
                    }

                    reliableWcfServiceClient.UpdateOrInsertQuotations(quotableQuotationsTo);

                    ts.Complete();
                    DisplayTransactionalStatus("Quotations replaced categories successfully in Transactional Mode..!!!!");
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    DisplayTransactionalStatus("Quotations replace categories failed in Transactional Mode..!!!!");
                }
            }
        }

        private void ReplaceNamesOfQuotations()
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotationsReadOnlyReliableWcfServiceClient
                        readOnlyReliableWcfServiceClient =
                            new QuotableQuotationsReadOnlyReliableWcfService.QuotableQuotationsReadOnlyReliableWcfServiceClient();
                    QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient reliableWcfServiceClient =
                        new QuotableQuotationsReliableWcfService.QuotableQuotationsReliableWcfServiceClient();

                    var namesFrom = txtFrom.Text.Split(new[] { "," }, StringSplitOptions.None);
                    var namesTo = txtTo.Text.Split(new[] { "," }, StringSplitOptions.None);

                    if (namesFrom.Length != namesTo.Length)
                        throw new Exception("From & To parameters must have equal entries!!");

                    var quotableQuotationsFrom = readOnlyReliableWcfServiceClient.GetQuotationsByNames(namesFrom);
                    var quotableQuotationsTo =
                        new QuotableQuotationsReliableWcfService.QuotableQuotation[quotableQuotationsFrom.Length];

                    for (int idx = 0; idx < quotableQuotationsFrom.Length; idx++)
                    {
                        quotableQuotationsFrom[idx].Name = namesTo[idx];
                        quotableQuotationsTo[idx] = new QuotableQuotationsReliableWcfService.QuotableQuotation
                        {
                            Id = quotableQuotationsFrom[idx].Id,
                            Name = quotableQuotationsFrom[idx].Name,
                            Category = quotableQuotationsFrom[idx].Category,
                            Quote = quotableQuotationsFrom[idx].Quote
                        };
                    }

                    reliableWcfServiceClient.UpdateOrInsertQuotations(quotableQuotationsTo);

                    ts.Complete();
                    DisplayTransactionalStatus("Quotations replaced names successfully in Transactional Mode..!!!!");
                }
                catch (Exception ex)
                {
                    ts.Dispose();
                    DisplayTransactionalStatus("Quotations replace names failed in Transactional Mode..!!!!");
                }
            }
        }

        private void ProcessNonTransactionalOperations()
        {
            if (rbRead.Checked)
            {
                var criteria = txtCriteria.Text;
                var quotes = FetchQuotableQuotations(criteria);
                DisplayResults(quotes);
            }
            else if (rbCreate.Checked)
            {
                CreateQuotableQuotation(txtQQName.Text, txtQQCategory.Text, txtQQQuote.Text);
            }
            else if (rbUpdate.Checked)
            {
                UpdateQuotableQuotation(txtQQId.Text, txtQQName.Text, txtQQCategory.Text, txtQQQuote.Text);
            }
            else if (rbDelete.Checked)
            {
                DeleteQuotableQuotation(txtQQId.Text);
            }
        }

        private void DeleteQuotableQuotation(string id)
        {
            wcfServiceClient.DeleteQuotation(Convert.ToInt32(id.Trim()));
            txtResult.Text = Resources.SuccessfulDeletionOfQuote;
        }

        private void UpdateQuotableQuotation(string id, string name, string category, string quote)
        {
            QuotableQuotation quotableQuotation = new QuotableQuotation
            {
                Name = name,
                Category = category,
                Quote = quote
            };
            wcfServiceClient.UpdateQuotation(Convert.ToInt32(id.Trim()), quotableQuotation);
            txtResult.Text = Resources.SuccessfulUpdationOfQuote;
        }

        private void CreateQuotableQuotation(string name, string category, string quote)
        {
            QuotableQuotation quotableQuotation = new QuotableQuotation
            {
                Name = name,
                Category = category,
                Quote = quote
            };
            wcfServiceClient.CreateQuotation(quotableQuotation);
            txtResult.Text = Resources.SuccessfulCreationOfQuote;
        }


        private List<QuotableQuotation> FetchQuotableQuotations(string criteria)
        {
            var quotes = new List<QuotableQuotation>();
            if (rbName.Checked)
            {
                quotes = FetchQuotationsByName(criteria).ToList();
            }
            else if (rbCategory.Checked)
            {
                quotes = FetchQuotationsByCategory(criteria).ToList();
            }
            else if (rbText.Checked)
            {
                quotes = FetchQuotationsByText(criteria).ToList();
            }
            return quotes;
        }

        private void DisplayResults(List<QuotableQuotation> quotes)
        {
            txtResult.Clear();
            var quotesResult = new List<string>();
            quotes.ForEach(q => quotesResult.Add($"id=\"{q.Id}\" Name=\"{q.Name}\"  Category=\"{q.Category}\" Quote=\"{q.Quote}\""));
            txtResult.Text = string.Join("\r\n", quotesResult);
        }

        private QuotableQuotation[] FetchQuotationsByText(string criteria)
        {
            return wcfServiceClient.GetQuotations(criteria);
        }

        private QuotableQuotation[] FetchQuotationsByCategory(string criteria)
        {
            return wcfServiceClient.GetQuotationsByCategory(criteria);
        }

        private QuotableQuotation[] FetchQuotationsByName(string criteria)
        {
            return wcfServiceClient.GetQuotationsByName(criteria);
        }
    }
}
