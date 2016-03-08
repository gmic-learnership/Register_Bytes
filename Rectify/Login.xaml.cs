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
using Rectify.Data;
using Rectify.Model;
using Rectify.ModelData;


namespace Rectify
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        Home home = new Home();     
        DigitalEntities digitalContext = null;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (digitalContext = new DigitalEntities())
            {
                var mentor = (from t in digitalContext.People
                               where String.Compare(t.Username, txtUsername.Text) == 0
                               && String.Compare(t.Password,txtPassword.Password) == 0
                               select t).FirstOrDefault();
                if (mentor != null && !String.IsNullOrEmpty(mentor.Username))
                {
                    SessionContext.UserID = mentor.PersonID;
                   SessionContext.UserRole = Role.Person;
                    SessionContext.UserName = mentor.FirstName;
                    SessionContext.CurrentMentor = mentor;
                    home.Show();                
                    home.btnManage.IsEnabled = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Please Try Again", MessageBoxButton.OK, MessageBoxImage.Error);                    
                }
              }           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsername.Focus();
        }
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            Mentor sf = new Mentor();
            sf.Show();
            this.Hide();
        }
    }
}


