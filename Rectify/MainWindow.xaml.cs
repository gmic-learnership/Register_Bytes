using Rectify.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Data.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Objects;
using Rectify.Model;
using Rectify.Data.ViewModel;

namespace Rectify
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Home home = null;
        private RegisterDBEntities RegisterContext = null;
        public void GetMentors()
        {
            try
            {             
                using (RegisterContext = new RegisterDBEntities())
                {
                    foreach (var d in RegisterContext.AttendanceMasters)
                    {
                        cmbMentorList.Items.Add(d.FirstName + "  " + d.LastName.Substring(0, 1).ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("mentors not found" + ex.Message);
            }
        }      
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {           
            RegisterContext = new RegisterDBEntities();
            datePicker.SelectedDate = DateTime.Now;
            cmbStudent.SelectedIndex = 1;
            cmbMentorList.SelectedIndex = 1;
            GetMentors();
            Username.Text = "Welcome ," + SessionContext.UserName;            
        }
        private void cmbMentorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int Index = cmbMentorList.SelectedIndex + 1;
                using (RegisterContext = new RegisterDBEntities())
                {
                    IList<Student> student = (from x in RegisterContext.Students                                             
                                              where x.MentorID == Index
                                              select x).ToList();           
                    cmbStudent.DataContext= student;
                    txtTotal.Text = "No. of Students" +"  " + cmbStudent.Items.Count.ToString();                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime picker = new DateTime();
            cmbStudent.SelectedIndex = 1;
            using (RegisterContext = new RegisterDBEntities())
            {
                picker = (DateTime)datePicker.SelectedDate;          
                IList<Student> student = (from x in RegisterContext.Students    
                                          from d in RegisterContext.AttendanceDetail1                              
                                          where d.AttendanceDate == picker && x.ID == d.StudentID
                                           select x).ToList();
                cmbStudent.DataContext = student;
                
                txtTotal.Text = "No. of Attendance(s)" + "  " + cmbStudent.Items.Count.ToString();
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SignModel signModel = new SignModel();

                AttendanceDetail1 detail = new AttendanceDetail1();
                detail.Task_Completed = txtTask.Text;
                detail.HoursPerDay = Convert.ToDecimal(txtHours.Text);
                detail.StudentID = SessionContext.UserID;
                detail.AttendanceDate = (DateTime)datePicker.SelectedDate;
                MessageBox.Show(signModel.SignRegister(detail));
                txtTask.Clear();
                txtHours.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }           
        }         
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
             home = new Home();
            home.Visibility = Visibility.Visible;
        }
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            popLink.IsOpen = false;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }
        private void btn_back(object sender, RoutedEventArgs e)
        {
            home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
