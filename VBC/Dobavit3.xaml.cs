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
    public partial class Dobavit3 : Page
    {
        Frame MainFrame;
        public Dobavit3(Frame MainFrame)
        {
            InitializeComponent();
            this.MainFrame = MainFrame;
        }

        private void DobavitClick_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new RedAvto();
        }
    }
}
