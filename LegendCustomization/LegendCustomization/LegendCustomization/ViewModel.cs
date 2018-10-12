using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LegendCustomization
{
    public class ViewModel
    {
        public ObservableCollection<Model> PieSeriesData { get; set; }

        public ViewModel()
        {
            PieSeriesData = new ObservableCollection<Model>
            {
                new Model("Rice", 70),
                new Model("Wheat", 62),
                new Model("Oil", 30),
                new Model("Corn", 26)
            };
        }
    }
}
