using Microcharts;
using Microcharts.Maui;
using SkiaSharp;

namespace maui_ch
{
    public partial class MainPage : ContentPage
    {       
        
        ChartEntry[] entries = new[]
            {
                new ChartEntry(200)
                {
                    Label = "January",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new ChartEntry(400)
                {
                    Label = "February",
                    ValueLabel = "400",
                    Color = SKColor.Parse("#68B9C0")
                },
                new ChartEntry(-100)
                {
                    Label = "March",
                    ValueLabel = "-100",
                    Color = SKColor.Parse("#90D585")
                }
            };

        public MainPage()
        {
            InitializeComponent();

            chartView.Chart = new BarChart() { Entries = entries };
        }       
    }
}
