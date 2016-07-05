using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace QuotableQuotations.WindowsServiceHosted
{
    public partial class QQWinService : ServiceBase
    {
        private ServiceHost m_svcHost = null;

        public QQWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (m_svcHost != null) m_svcHost.Close();

            string strAdrHTTP = "http://localhost:41293/QuotableQuotationsWcfService";
            string strAdrTCP = "net.tcp://localhost:41294/QuotableQuotationsWcfService";

            Uri[] adrbase = { new Uri(strAdrHTTP), new Uri(strAdrTCP) };
            m_svcHost = new ServiceHost(typeof(Services.Classes.QuotableQuotationsWcfService), adrbase);

            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
            m_svcHost.Description.Behaviors.Add(mBehave);

            BasicHttpBinding httpb = new BasicHttpBinding();
            m_svcHost.AddServiceEndpoint(typeof(Contracts.Interfaces.IQuotableQuotationsWcfService), httpb, strAdrHTTP);
            m_svcHost.AddServiceEndpoint(typeof(IMetadataExchange),
            MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            NetTcpBinding tcpb = new NetTcpBinding();
            m_svcHost.AddServiceEndpoint(typeof(Contracts.Interfaces.IQuotableQuotationsWcfService), tcpb, strAdrTCP);
            m_svcHost.AddServiceEndpoint(typeof(IMetadataExchange),
            MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

            m_svcHost.Open();
        }

        protected override void OnStop()
        {
            if (m_svcHost != null)
            {
                m_svcHost.Close();
                m_svcHost = null;
            }
        }
    }
}
