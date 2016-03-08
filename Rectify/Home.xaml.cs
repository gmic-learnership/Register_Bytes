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
using System.Windows.Shapes;
using Rectify.Model;
using Rectify.Data;

namespace Rectify
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {                    
            MainWindow StudentListMenu = new MainWindow();         
            StudentListMenu.Show();
            this.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginName.Text = "Welcome, " + SessionContext.UserName;
        }
        private void btnManage_Click(object sender, RoutedEventArgs e)
        {          
          
        }
        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }
        private void SignOut()
        {
            popLink.IsOpen = false;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            SignOut();
        }
        private void btn_back(object sender, RoutedEventArgs e)
        {
            SignOut();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            popLink.IsOpen = false;
            About about = new About();
            about.Show();
            this.Hide();
        }
        
    }
}
