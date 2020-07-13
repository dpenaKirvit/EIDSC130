using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Gauges;
using EIDS.Instrumentos;

namespace EIDS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            var abc = Screen.AllScreens;
            if (abc.Length<5)
            {
                InitializeComponent();
                _1 w1 = new _1();
                _2 w2 = new _2();
                ShowOnMonitor(4, w2);
                ShowOnMonitor(1, w1);
                ShowOnMonitor(3, this);
                w2.Show();
                w1.Show();
            }
        }
        private void ShowOnMonitor(int monitor, Window window)
        {
            var screen = ScreenHandler.GetScreen(monitor);
            var currentScreen = ScreenHandler.GetCurrentScreen(this);
            window.WindowState = WindowState.Normal;
            window.Left = screen.WorkingArea.Left;
            window.Top = screen.WorkingArea.Top;
            window.Width = screen.WorkingArea.Width;
            window.Height = screen.WorkingArea.Height;
            window.Loaded += Window_Loaded;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var senderWindow = sender as Window;
            senderWindow.WindowState = WindowState.Maximized;
        }
    }
}
