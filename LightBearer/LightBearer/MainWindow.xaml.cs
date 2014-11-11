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
using System.Windows.Threading;

namespace Lightbearer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            MessageBox.Show("Set time values then click \"Start\" button. Good luck!", "The Lightbearer Assistance by Beat Generation");
        }


         void CountDown()
        {
        
             System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

                dispatcherTimer.Interval = new TimeSpan(0,0,59); //3 sekundy
                dispatcherTimer.Tick += dispatcherTimer_Tick;
                dispatcherTimer.Start();




        }

         void dispatcherTimer_Tick(object sender, EventArgs e)
         {
             YalaTime.Text = Convert.ToString((Int16.Parse(YalaTime.Text) - 1));
             EdronTime.Text = Convert.ToString((Int16.Parse(EdronTime.Text) - 1));
             BBTime.Text = Convert.ToString((Int16.Parse(BBTime.Text) - 1));
             TarpitTime.Text = Convert.ToString((Int16.Parse(TarpitTime.Text) - 1)); ;
             SvarTime.Text = Convert.ToString((Int16.Parse(SvarTime.Text) - 1));
             PohTime.Text = Convert.ToString((Int16.Parse(PohTime.Text) - 1));
             KazoTime.Text = Convert.ToString((Int16.Parse(KazoTime.Text) - 1)); ;
             DrefiaTime.Text = Convert.ToString((Int16.Parse(DrefiaTime.Text) - 1));
             ForbTime.Text = Convert.ToString((Int16.Parse(ForbTime.Text) - 1));
             HellgateTime.Text = Convert.ToString((Int16.Parse(HellgateTime.Text) - 1));
         }

        

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            CountDown();            
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            TarpitTime.Text = "120";
            YalaTime.Text = "120";
            EdronTime.Text = "120";
            SvarTime.Text = "120";
            BBTime.Text = "120";
            DrefiaTime.Text = "120";
            PohTime.Text = "120";
            KazoTime.Text = "120";
            ForbTime.Text = "120";
            HellgateTime.Text = "120";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TarpitTime.Text = "120";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DrefiaTime.Text = "120";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            KazoTime.Text = "120";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ForbTime.Text = "120";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            HellgateTime.Text = "120";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EdronTime.Text = "120";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            SvarTime.Text = "120";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            YalaTime.Text = "120";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            BBTime.Text = "120";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PohTime.Text = "120";
        }

        private void RestartButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("Tarpit (" + TarpitTime.Text + " min) - Drefia (" + DrefiaTime.Text + " min) - Kazzo (" + KazoTime.Text + " min) - Forbidden Lands (" + ForbTime.Text + " min) - Hellgate (" + HellgateTime.Text + " min) - Edron (" + EdronTime.Text + " min) - POH (" + PohTime.Text + " min) - Svargrond (" + SvarTime.Text + " min) - Yala Hellspawns (" + YalaTime.Text + " min) - BB Island (" + BBTime.Text + " min)");
        }


    }
}
