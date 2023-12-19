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

namespace VBC
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

        private void PocupateliCick_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dobavit(MainFrame);
        }

        private void MarkiClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dobavit1(MainFrame);
        }

        private void SotrudnickiClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dobavit2(MainFrame);
        }

        private void AvtomobilClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dobavit3(MainFrame);
        }

        private void ProdajiClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Dobavit4(MainFrame);
        }
    }
}
