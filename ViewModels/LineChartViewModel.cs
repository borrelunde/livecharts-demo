using LiveCharts.Wpf;
using LiveCharts;
using Prism.Mvvm;

namespace livecharts_demo.ViewModels
{
    public class LineChartViewModel : BindableBase
    {
        private SeriesCollection? seriesCollection;

        public SeriesCollection? SeriesCollection
        {
            get => seriesCollection;
            set => SetProperty(ref seriesCollection, value);
        }

        public LineChartViewModel()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                }
            };
        }
    }
}
