using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                MessageBox.Show((sender as Button).Content.ToString());
                this.Hide();
                Window1 myw = new Window1();
                myw.ShowDialog();
                this.Show();

            }
        }
        private void ReportTimeAHandler(object sender, ReportTimeAEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format("{0} 到达{1} ",timeStr,element.Name);
            this.listBox.Items.Add(content);
        }


    }
    class ReportTimeAEventArgs : RoutedEventArgs
    {
        public ReportTimeAEventArgs(RoutedEvent routeEvent, object source) : base(routeEvent, source) { }
        public DateTime ClickTime
        {
            get; set;
        }
    }
    public class TimeButton : Button
    {
        public static readonly RoutedEvent ReportTimeAEvent = EventManager.RegisterRoutedEvent(
            "ReportTimeA", RoutingStrategy.Tunnel, typeof(EventHandler<ReportTimeAEventArgs>), typeof(TimeButton));
        public event RoutedEventHandler ReportTimeA
        {
            add { this.AddHandler(ReportTimeAEvent, value); }
            remove { this.RemoveHandler(ReportTimeAEvent, value); }
        }
        protected override void OnClick()
        {
            base.OnClick();
            ReportTimeAEventArgs args = new ReportTimeAEventArgs(ReportTimeAEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
}
