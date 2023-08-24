using DesExemples.Views;

namespace DesExemples
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MasterHomePage), typeof(MasterHomePage));
        }
    }
}