using LiveCharts.Wpf;
using LiveCharts;
using Prism.Mvvm;

namespace livecharts_demo.ViewModels
{
    public class HistogramViewModel : BindableBase
    {
        private SeriesCollection? seriesCollection;

        public SeriesCollection? SeriesCollection
        {
            get => seriesCollection;
            set => SetProperty(ref seriesCollection, value);
        }

        public HistogramViewModel()
        {
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 2, 5, 8, 3 }
                }
            };
        }
    }
}
