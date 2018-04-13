using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GetGraphSample
{
    /// <summary>
    /// UCRectangle.xaml 的交互逻辑
    /// </summary>
    public partial class UCRectangle : UserControl
    {
        /// <summary>
        /// 原始鼠标按下
        /// </summary>
        private Point origMouseDownPoint;
        /// <summary>
        /// 鼠标左键是否在窗口
        /// </summary>
        private bool isLeftMouseButtonDownOnWindow = false;
        /// <summary>
        /// 拖动选择矩形
        /// </summary>
        private bool isDraggingSelectionRect = false;
        /// <summary>
        /// 拖动值
        /// </summary>
        private static readonly double DragThreshold = 5;

        private UCRectangleViewModel ViewModel
        {
            get
            {
                return (UCRectangleViewModel)this.DataContext;
            }
        }
        public UCRectangle()
        {
            InitializeComponent();
            listBox.Focus();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
               
                listBox.SelectedItems.Clear();

                isLeftMouseButtonDownOnWindow = true;
                origMouseDownPoint = e.GetPosition(this);

                this.CaptureMouse();

                e.Handled = true;
            }
        }

        
        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                bool wasDragSelectionApplied = false;

                if (isDraggingSelectionRect)
                {
                    
                    isDraggingSelectionRect = false;
                    ApplyDragSelectionRect();

                    e.Handled = true;
                    wasDragSelectionApplied = true;
                }

                if (isLeftMouseButtonDownOnWindow)
                {
                    isLeftMouseButtonDownOnWindow = false;
                    this.ReleaseMouseCapture();

                    e.Handled = true;
                }

                if (!wasDragSelectionApplied)
                {
                   
                    listBox.SelectedItems.Clear();
                }
            }
        }

      
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingSelectionRect)
            {
               
                Point curMouseDownPoint = e.GetPosition(this);
                UpdateDragSelectionRect(origMouseDownPoint, curMouseDownPoint);

                e.Handled = true;
            }
            else if (isLeftMouseButtonDownOnWindow)
            {
              
                Point curMouseDownPoint = e.GetPosition(this);
                var dragDelta = curMouseDownPoint - origMouseDownPoint;
                double dragDistance = Math.Abs(dragDelta.Length);
                if (dragDistance > DragThreshold)
                {
                    
                    isDraggingSelectionRect = true;
                    InitDragSelectionRect(origMouseDownPoint, curMouseDownPoint);
                }

                e.Handled = true;
            }
        }

        private void InitDragSelectionRect(Point pt1, Point pt2)
        {
            UpdateDragSelectionRect(pt1, pt2);

            dragSelectionCanvas.Visibility = Visibility.Visible;
        }

       
        private void UpdateDragSelectionRect(Point pt1, Point pt2)
        {
            double x, y, width, height;

            if (pt2.X < pt1.X)
            {
                x = pt2.X;
                width = pt1.X - pt2.X;
            }
            else
            {
                x = pt1.X;
                width = pt2.X - pt1.X;
            }

            if (pt2.Y < pt1.Y)
            {
                y = pt2.Y;
                height = pt1.Y - pt2.Y;
            }
            else
            {
                y = pt1.Y;
                height = pt2.Y - pt1.Y;
            }

          
            Canvas.SetLeft(dragSelectionBorder, x);
            Canvas.SetTop(dragSelectionBorder, y);
            dragSelectionBorder.Width = width;
            dragSelectionBorder.Height = height;
        }

       
        private void ApplyDragSelectionRect()
        {
            dragSelectionCanvas.Visibility = Visibility.Collapsed;

            double x = Canvas.GetLeft(dragSelectionBorder);
            double y = Canvas.GetTop(dragSelectionBorder);
            double width = dragSelectionBorder.Width;
            double height = dragSelectionBorder.Height;
            Rect dragRect = new Rect(x, y, width, height);

           
            dragRect.Inflate(width / 10, height / 10);
            string GetTheValue = string.Empty;
            foreach (RectangleModel rectangleModel in this.ViewModel.Rectangles)
            {
                Rect itemRect = new Rect(rectangleModel.X, rectangleModel.Y, rectangleModel.Width, rectangleModel.Height);
                if (dragRect.Contains(itemRect))
                {
                    GetTheValue += rectangleModel.ToolTip + ",";
                }
            }
            if (GetTheValue.Length>0)
            {
                MessageBox.Show("你选中了："+GetTheValue);
            }
        }
    }
}
