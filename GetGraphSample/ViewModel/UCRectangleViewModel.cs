using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace GetGraphSample
{
    public class UCRectangleViewModel : ModelObject
    {
        private ObservableCollection<RectangleModel> rectangles = new ObservableCollection<RectangleModel>();
        public UCRectangleViewModel()
        {
            var r1 = new RectangleModel(10, 10, 50, 40, Colors.Pink, GetUUID(),"粉色");
            rectangles.Add(r1);
            var r2 = new RectangleModel(70, 60, 50, 60, Colors.PaleVioletRed, GetUUID(), "灰紫紅");
            rectangles.Add(r2);
            var r3 = new RectangleModel(150, 130, 55, 48, Colors.PeachPuff, GetUUID(),"桃色");
            rectangles.Add(r3);
        }
        public string GetUUID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public ObservableCollection<RectangleModel> Rectangles
        {
            get
            {
                return rectangles;
            }
        }
    }
}
