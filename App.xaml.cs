using System.Windows;

namespace livecharts_demo
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrapper bootstrapper = new();
            bootstrapper.Run();
        }
    }
}
