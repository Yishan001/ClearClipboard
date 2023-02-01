using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ClearClipboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();

            Clipboard.Clear();

            SetTimer();
        }

        private static void SetTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer(500);
            aTimer.Elapsed += OnTimerEvent;
            aTimer.Start();
        }

        private static void OnTimerEvent(Object? source, System.Timers.ElapsedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
