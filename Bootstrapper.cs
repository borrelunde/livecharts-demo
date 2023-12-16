using livecharts_demo.ViewModels;
using livecharts_demo.Views;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using System.Windows;

namespace livecharts_demo
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register views
            containerRegistry.RegisterForNavigation<LineChartView>();
            containerRegistry.RegisterForNavigation<HistogramView>();

            // Register view models
            containerRegistry.Register<LineChartViewModel>();
            containerRegistry.Register<HistogramViewModel>();
        }

        protected override void Initialize()
        {
            base.Initialize();

            IRegionManager regionManager = Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegionA", "LineChartView");
            regionManager.RequestNavigate("ContentRegionB", "HistogramView");
        }
    }
}