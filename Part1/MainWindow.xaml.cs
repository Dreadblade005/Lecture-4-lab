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

namespace Part1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speed_limit;
            double speed;
            speed = double.Parse(YourSpeed.Text);
            speed_limit = double.Parse(SpeedLimit.Text);

            double fine = 0;
            double big_fine = 250;
            double total_fine = 0;


            if (speed > speed_limit && speed < speed_limit + 5)
            {
                Range.Background = Brushes.Yellow;
                status_label.Content = "Yellow";
                fine = 60 + 7 * (speed - speed_limit);
                MessageBox.Show("You are going a bit too fast and will get lightly punished; your fine is: " + fine + "$");


            }
            else if (speed <= speed_limit)
            {
                Range.Background = Brushes.Green;
                status_label.Content = "Green";
                MessageBox.Show("Your are within the speed limit, good job.");
            }
            else
            {
                Range.Background = Brushes.Red;
                status_label.Content = "Red";
                fine = 60 + 7 * (speed - speed_limit);
                if (speed > speed_limit + 25)
                {
                    total_fine = fine += big_fine;
                    MessageBox.Show("You are way above the speed limit and will get a huge fine; your fine is: " + total_fine + "$");
                }
                else
                {
                    total_fine = fine;
                    MessageBox.Show("You are above the speed limit and will get a fine; your fine is: " + fine + "$");

                }

            }
        }
    }
}
