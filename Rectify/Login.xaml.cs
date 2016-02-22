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



namespace Rectify
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
         
        Home home = new Home();
     
        RegisterDBEntities registerContext = null;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (registerContext = new RegisterDBEntities())
            {
                var mentor = (from t in registerContext.AttendanceMasters
                               where String.Compare(t.Username, txtUsername.Text) == 0
                               && String.Compare(t.Password,txtPassword.Password) == 0
                               select t).FirstOrDefault();

                var student = (from stud in registerContext.Students
                               where String.Compare(stud.Username, txtUsername.Text) == 0
                               && String.Compare(stud.Password, txtPassword.Password) == 0
                               select stud).FirstOrDefault();
                if (mentor != null && !String.IsNullOrEmpty(mentor.Username))
                {
                    SessionContext.UserID = mentor.ID;
                    SessionContext.UserRole = Role.AttendanceMaster;
                    SessionContext.UserName = mentor.FirstName;
                    SessionContext.CurrentTeacher = mentor;
                    home.HorizontalAlignment = HorizontalAlignment.Center;
                    home.Show();                
                    home.btnManage.IsEnabled = true;
                    this.Close();
                }
                else if (student != null && !String.IsNullOrEmpty(student.Username) )
                    {
                        SessionContext.UserID = student.ID;
                        SessionContext.UserRole = Role.Student;
                        SessionContext.UserName = student.FirstName;

                        SessionContext.CurrentStudent = student;                                   
                        home.Show();
                        home.btnManage.IsEnabled = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Logon Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                }
              }           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsername.Focus();
        }

        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
            this.Hide();
        }
    }
}


