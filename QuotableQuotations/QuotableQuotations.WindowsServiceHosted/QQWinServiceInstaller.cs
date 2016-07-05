using System.ComponentModel;
using System.ServiceProcess;

namespace QuotableQuotations.WindowsServiceHosted
{
    [RunInstaller(true)]
    public partial class QqWinServiceInstaller : System.Configuration.Install.Installer
    {
        public QqWinServiceInstaller()
        {
            //InitializeComponent();
            serviceProcessInstaller1 = new ServiceProcessInstaller();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1 = new ServiceInstaller();
            serviceInstaller1.ServiceName = "WinSvcHostedQuotableQuotationsService";
            serviceInstaller1.DisplayName = "WinSvcHostedQuotableQuotationsService";
            serviceInstaller1.Description = "WCF QuotableQuotations Service Hosted by Windows NT Service";
            serviceInstaller1.StartType = ServiceStartMode.Automatic;
            Installers.Add(serviceProcessInstaller1);
            Installers.Add(serviceInstaller1);
        }
    }
}
