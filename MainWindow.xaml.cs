
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

namespace oginpage
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

       

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonlogin_Click(object sender, RoutedEventArgs e)
        {
            if (chek.IsChecked == false)
            {
                MessageBox.Show("please tcheck");
            }
            if (gmail1.Text == "salah@gmail.com" && password1.Text == "salah2004")
            {
                MessageBox.Show("Your account is found........");
            }
            else
            {
                MessageBox.Show("Sorry your account not found.....");
            }

        }
        
    }
}
