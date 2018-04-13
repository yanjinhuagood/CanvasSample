using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace GetGraphSample
{
    public class RectangleModel : ModelObject
    {
       
        private double x = 0;
       
        private double y = 0;

        private double width = 0;
      
        private double height = 0;

        private Color color;

        private string uuid;

        private string toolTip;

        public RectangleModel(double x, double y, double width, double height, Color color, string uuid, string toolTip)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            this.uuid = uuid;
            this.toolTip = toolTip;
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (x == value)
                {
                    return;
                }

                x = value;

                RaisePropertyChanged("X");
            }
        }


        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (y == value)
                {
                    return;
                }

                y = value;

                RaisePropertyChanged("Y");
            }
        }


        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (width == value)
                {
                    return;
                }

                width = value;

                RaisePropertyChanged("Width");
            }
        }


        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (height == value)
                {
                    return;
                }

                height = value;

                RaisePropertyChanged("Height");
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                if (color == value)
                {
                    return;
                }

                color = value;

                RaisePropertyChanged("Color");
            }
        }
        public string UUID
        {
            get
            {
                return uuid;
            }
            set
            {
                if (uuid == value)
                {
                    return;
                }

                uuid = value;

                RaisePropertyChanged("UUID");
            }
        }
        public string ToolTip
        {
            get
            {
                return toolTip;
            }
            set
            {
                if (toolTip == value)
                {
                    return;
                }

                toolTip = value;

                RaisePropertyChanged("ToolTip");
            }
        }
    }
}
