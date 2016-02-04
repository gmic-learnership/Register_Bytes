using Rectify.Data;
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

namespace Rectify
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        RegisterDBEntities RegisterContext = null;
        // Field for tracking the currently selected teacher
        private AttendanceMaster _mentor = null;
        public StudentForm()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegisterDBEntities RegisterContext = new RegisterDBEntities();
            MainWindow mw = new MainWindow();
            cmbStudentMentor.ItemsSource = mw.GetMentors();
            this.cmbStudentMentor.SelectedValue = "Select Mentor";
     
        
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();

        }
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (RegisterContext = new RegisterDBEntities())
                {
                    _mentor = new AttendanceMaster();

                    Student student = new Student();
                    student.FirstName = txtFirstName.Text;
                    student.LastName = txtLastname.Text;
                    student.Email = txtEmail.Text;
                    student.Home_Address = txtHome_Address.Text;
                    student.DateOfBirth = DateTime.Parse(dtPicker.SelectedDate.ToString());
                    student.MentorID = cmbStudentMentor.SelectedIndex; ;
                    student.Phone = txtNumber.Text;

                    this._mentor.Students.Add(student);
                    this.RegisterContext.Students.Add(student);
                    this.RegisterContext.SaveChanges();
                }              
            }
            catch(Exception ex)
            {
                MessageBox.Show("User was not added" + "   "  + ex.Message);
            }
            
        }
        private void addnewStudent()
        {
            
        }
        private void ValiddateInput()
        {
            if (String.IsNullOrEmpty(this.txtFirstName.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (String.IsNullOrEmpty(this.txtLastname.Text))
            {
                MessageBox.Show("The student must have a last name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            else if (String.IsNullOrEmpty(this.txtEmail.Text))
            {
                MessageBox.Show("The student must have an Email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (String.IsNullOrEmpty(this.txtHome_Address.Text))
            {
                MessageBox.Show("The student must have Address", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (String.IsNullOrEmpty(this.txtNumber.Text))
            {
                MessageBox.Show("The student must have Contact number", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
          
        }
       }
            
    

}

