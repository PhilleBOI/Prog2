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

namespace Luffarschack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btnTic1.Enable = false;
            btnTic2.Enable = false;
            btnTic3.Enable = false;
            btnTic4.Enable = false;
            btnTic5.Enable = false;
            btnTic6.Enable = false;
            btnTic7.Enable = false;
            btnTic8.Enable = false;
            btnTic9.Enable = false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
