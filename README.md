# How to customize the individual legend item based on a condition in Xamarin.Forms Chart (SfChart)?

You can customize all the legend items by setting individual style using the [LegendItemCreated](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.SfChart.html) event. This event will be fired when a chart legend item is created. For more details about the event arguments, refer to this [documentation](https://help.syncfusion.com/xamarin/sfchart/legend#event).

The following code sample demonstrates how to set individual style to all the legend items.

**XAML**
```
<chart:SfChart x:Name="chart" LegendItemCreated="Chart_LegendItemCreated">
```

**C#**
```
chart.LegendItemCreated += Chart_LegendItemCreated;
 
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
```

## Output:

![Pie Chart with customized legend items in Xamarin.Forms](https://user-images.githubusercontent.com/53489303/200599019-d705a88f-6a5b-41fd-b617-d91496f059d5.png)

KB article - [How to customize the individual legend item based on a condition in Xamarin.Forms Chart?](https://www.syncfusion.com/kb/9375/how-to-customize-the-individual-legend-item-based-on-a-condition-in-xamarin-forms-chart)

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
