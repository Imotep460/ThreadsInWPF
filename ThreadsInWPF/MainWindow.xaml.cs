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
using System.Threading;

namespace ThreadsInWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sensor(object o)
        {
            Label l = (Label) o;
            Random r = new Random();
            while (SensorsRunning)
            {
                Thread.Sleep(1000);
                double temp = 10 + r.NextDouble() * 15;


                //tilføj kode her som overfører temp til vinduets label
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
