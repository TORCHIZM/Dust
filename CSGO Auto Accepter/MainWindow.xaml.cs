using CSGO_Auto_Accepter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSGO_Auto_Accepter
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Timer t = new Timer()
        {
            Interval = 1000
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            t.Elapsed += T_Elapsed;
            t.Start();
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            var coords = ImageRecognition.GetCoordinates(Properties.Resources.Accept_1920x1080);
            if (coords != null) {
                MouseController.MoveAndLeftClick(coords.X, coords.Y);
                MouseController.LeftClick();
            }
        }
    }
}
