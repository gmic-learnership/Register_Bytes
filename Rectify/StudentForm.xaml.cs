using Rectify.Data;
using Rectify.Data.ViewModel;
using Rectify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Rectify
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        RegisterDBEntities RegisterContext = null;
        public StudentForm()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegisterDBEntities RegisterContext = new RegisterDBEntities();
            txtFirstName.Focus();
            cmbStudentMentor.SelectedIndex = 1;
            LoginName.DataContext = "Welcome, " + SessionContext.UserName;
            foreach (var d in RegisterContext.AttendanceMasters)
            {
                cmbStudentMentor.Items.Add(d.FirstName + "  " + d.LastName.Substring(0, 1).ToUpper());
            }                        
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            ValidateInput();
        }
        private void ValidateInput()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtFirstName.Text) || String.IsNullOrEmpty(this.txtLastName.Text) || String.IsNullOrEmpty(this.txtNumber.Text)
              || String.IsNullOrEmpty(this.txtHome_Address.Text) || String.IsNullOrEmpty(this.txtHome_Address.Text) || String.IsNullOrEmpty(this.ConfirmPassword.Password)
              || String.IsNullOrEmpty(this.passoword.Password) || String.IsNullOrEmpty(this.txtEmail.Text))
                {
                    MessageBox.Show("Required fields cannot be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if ((!Regex.IsMatch(txtEmail.Text, @"^((([\w]+\.[\w]+)+)|([\w]+))@(([\w]+\.)+)([A-Za-z]{1,3})$")))
                {
                    MessageBox.Show("Please enter a valid email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if (!Regex.IsMatch(this.passoword.Password, @".*[0-9]+.*[0-9]+.*"))
                {
                    MessageBox.Show("Password must contain atleast two numeric character", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (this.passoword.Password.Length < 8)
                {
                    MessageBox.Show("Password must be 8 characters long","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if (String.Compare(passoword.Password, ConfirmPassword.Password) != 0)
                {
                    MessageBox.Show("Password must match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if( txtNumber.Text.Length != 10  )
                {
                    MessageBox.Show("The phone number must be 10 digits long", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }              
                else
                {
                    using (RegisterContext = new RegisterDBEntities())
                    {
                        Student student = new Student();
                        SignModel signModel = new SignModel();
                        student.FirstName = txtFirstName.Text;
                        student.LastName = txtLastName.Text;
                        student.Username = txtEmail.Text;
                        student.Home_Address = txtHome_Address.Text;
                        student.Password = passoword.Password;
                        student.DateOfBirth = (DateTime)dtPicker.SelectedDate;
                        student.MentorID = cmbStudentMentor.SelectedIndex + 1; ;
                        student.Phone = txtNumber.Text;
                        MessageBox.Show(signModel.InsertLearner(student));
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error has occoured");
            }          
        }
        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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
            About about = new About();
            about.Show();
            this.Hide();
        }
    }
  }            

