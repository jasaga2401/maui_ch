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
                    Color = SKColor.Parse("#3489eb")
                },
                new ChartEntry(400)
                {
                    Label = "February",
                    ValueLabel = "400",
                    Color = SKColor.Parse("#094b96")
                },
                new ChartEntry(200)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#2f4157")
                }
            };

        public MainPage()
        {
            InitializeComponent();

            chartView.Chart = new LineChart() 
            { 
                Entries = entries,
                LabelTextSize = 40
            };            
        }       
    }
}
