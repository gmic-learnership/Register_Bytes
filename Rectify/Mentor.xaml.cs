using Rectify.Data.ViewModel;
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
using System.Text.RegularExpressions;
using Rectify.Model;
using Rectify.ModelData;

namespace Rectify
{
    /// <summary>
    /// Interaction logic for Mentor.xaml
    /// </summary>
    public partial class Mentor : Window
    {
        public Mentor()
        {
            InitializeComponent();
        }
        private DigitalEntities digitalContext = null;
        private void btnRegiter_Click(object sender, RoutedEventArgs e)
        {
            ValidateInput();
        }
        private void ValidateInput()
        {

            if(string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Password) || string.IsNullOrEmpty(txtConfirm.Password))
            {
                MessageBox.Show("Required fields cannot be Empty","ERROR",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            if (this.txtPassword.Password.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if(!Regex.IsMatch(this.txtPassword.Password, @".*[0-9]+.*[0-9]+.*"))
            {
                MessageBox.Show("Password must contain atleast two numeric character", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if(string.Compare(txtPassword.Password,txtConfirm.Password) > 0)
            {
                MessageBox.Show("Password must match","ERROR",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }

            else if((!Regex.IsMatch(txtUsername.Text, @"^((([\w]+\.[\w]+)+)|([\w]+))@(([\w]+\.)+)([A-Za-z]{1,3})$")))
            {
                MessageBox.Show("Email must contains, @jhb.dvt.co.za", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                SignModel sign = new SignModel();
                Person mentor = new Person();
                mentor.FirstName = txtFname.Text;
                mentor.LastName = txtLname.Text;
                mentor.Username = txtUsername.Text;
                mentor.Password = txtPassword.Password;
                mentor.RoleID = cmbStudentMentor.SelectedIndex + 1;
                MessageBox.Show(sign.InsertMentor(mentor));
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
        private void btn_back(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (digitalContext = new DigitalEntities())
                {
                    List<UserRole> role = (from x in digitalContext.UserRoles
                                           select x).ToList();

                    foreach (var item in role)
                    {
                        cmbStudentMentor.Items.Add(item.Name);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            popLink.IsOpen = false;
            Login login = new Login();
            login.Show();
            this.Hide();
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
