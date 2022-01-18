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

namespace WPFApp4_Converter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double rezsumDollar = rateDollar*sumDollar;
            rezsum.Text = rezsumDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvr = Convert.ToDouble(rateEvro.Text);
            double sumEvr = Convert.ToDouble(sumEvro.Text);
            double rezsumEvr = rateEvr * sumEvr;
            rezsumEvro.Text = rezsumEvr.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double ratefunt = Convert.ToDouble(rateFunt.Text);
            double sumfunt = Convert.ToDouble(sumFunt.Text);
            double rezsumfunt = ratefunt * sumfunt;
            rezsumFunt.Text = rezsumfunt.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateyuan = Convert.ToDouble(rateYuan.Text);
            double sumyuan = Convert.ToDouble(sumYuan.Text);
            double rezsumyuan = rateyuan * sumyuan;
            rezsumYuan.Text = rezsumyuan.ToString();
        }
    }
}
