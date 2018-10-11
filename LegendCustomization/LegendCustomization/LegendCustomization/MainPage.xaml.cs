using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LegendCustomization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

			/* C# code snippet
            chart.LegendItemCreated += Chart_LegendItemCreated;
            */
        }

        private void Chart_LegendItemCreated(object sender, ChartLegendItemCreatedEventArgs e)
        {
            Model model = e.LegendItem.DataPoint as Model;
            e.LegendItem.Label = model.XValue + ": " + model.YValue.ToString();
            e.LegendItem.LabelStyle = new ChartLegendLabelStyle()
            {
                TextColor = model.YValue > 50 ? Color.Green : Color.Red,
                FontFamily = model.YValue > 50 ? "Times New Roman" : "Arial"
            };
        }
    }
}
