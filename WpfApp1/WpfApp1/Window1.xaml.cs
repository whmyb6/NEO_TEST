using Microsoft.WindowsAPICodePack.Dialogs;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            InitializeCommand();

            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.Button_Click));
            this.gridMain.AddHandler(Student.NameChangedEvent, new RoutedEventHandler(this.StudendNameChanged));
        }
        private RoutedCommand routeCmd = new RoutedCommand("清除", typeof(Window1));
        private void InitializeCommand()
        {
            this.button2.Command = this.routeCmd;
            this.routeCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));
            this.button2.CommandTarget = this.textBox2;

            CommandBinding cb = new CommandBinding();
            cb.Command = this.routeCmd;
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Executed);

            this.stackPanel.CommandBindings.Add (cb);
        }

        private void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBox2.Clear();
            e.Handled = true;
        }

        void cb_CanExecute(object sender,CanExecuteRoutedEventArgs e) {
            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                e.CanExecute = false;
            }
            else
                e.CanExecute = true;
            e.Handled = true;
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strOriginalSource = string.Format("VisualTree start point is  {0}, type is {1}", (e.OriginalSource as FrameworkElement).Name, e.OriginalSource.GetType().Name);
            string strSoucer = string.Format("LogicalTree start point is {0}, type is {1}", (e.Source as FrameworkElement).Name, e.Source.GetType().Name);
            MessageBox.Show(strOriginalSource +"\r\n"+ strSoucer);
            //throw new NotImplementedException();
        }

        private void on_Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student() { id= 10,name =  "www" };
            //stu.name = "hello whm";
            RoutedEventArgs arg = new RoutedEventArgs(Student.NameChangedEvent, stu);
            this.button1.RaiseEvent(arg);
            
            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();
            daY.From = 0D;
            daX.From = 0D;

            Random r = new Random();
            daX.To = r.NextDouble() * 300;
            daY.To = r.NextDouble() * 300;

            Duration duration = new Duration(TimeSpan.FromMilliseconds(500));
            daX.Duration = duration;
            daY.Duration = duration;

            this.button1_movie.BeginAnimation(TranslateTransform.XProperty, daX);
            this.button1_movie.BeginAnimation(TranslateTransform.YProperty, daY);





        }
        private void StudendNameChanged(object sender,RoutedEventArgs args)
        {
            MessageBox.Show((args.OriginalSource as Student).id.ToString() + " " +(args.OriginalSource as Student).name);
        }

        private void select_file(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog open = new CommonOpenFileDialog();
            open.EnsureReadOnly = true;
            open.Filters.Add(new CommonFileDialogFilter("Mp4文件", "*.mp4"));
            open.Filters.Add(new CommonFileDialogFilter("Wmv文件", "*.wmv"));
            open.Filters.Add(new CommonFileDialogFilter("Avi文件", "*.avi"));
            open.Filters.Add(new CommonFileDialogFilter("Mp3文件", "*.mp3"));
            if (open.ShowDialog() == CommonFileDialogResult.Ok)
            {
                //指定媒体文件地址
                mediaElement.Source = new Uri(open.FileName, UriKind.Relative);
                playBtn.IsEnabled = true;
            }

        }

   
        private void playfile(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
            mediaElement.ToolTip = "开始播放";
            playBtn.IsEnabled = false;

        }
    }
    public class Student
    {
        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent("NameChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Student));
        public int id{get;set;}
        public string name { get; set; }
    }
}
