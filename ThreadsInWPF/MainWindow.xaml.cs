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
        bool SensorsRunning = true;
        object _lock = new object();
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
                lock (_lock)
                {
                    double temp = r.Next(10, 26);
                    Dispatcher.Invoke(new Action(() => { l.Content = "Temp: " + temp; }));
                }
                
                //l.Content = temp;

                
                //tilføj kode her som overfører temp til vinduets label
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(Sensor);
            }
            threads[0].Start(Label1);
            threads[1].Start(Label2);
            threads[2].Start(Label3);
            threads[3].Start(Label4);
            threads[4].Start(Label5);
            threads[5].Start(Label6);
            threads[6].Start(Label7);
            threads[7].Start(Label8);
            threads[8].Start(Label9);
            threads[9].Start(Label10);

        }
    }
}
