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

        private RegisterDBEntities RegisterContext = null;              
        public IList<AttendanceMaster> GetMentors()
        {
            try
            {
                using (RegisterDBEntities db = new RegisterDBEntities())
                {
                    IList<AttendanceMaster> _mentor = (from x in db.AttendanceMasters select x).ToList();
                    return _mentor;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }         
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegisterContext = new RegisterDBEntities();
            cmbMentorList.DataContext = this.GetMentors();
            this.UpdateLayout();
          
        }
        private void cmbMentorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
            try
            {
                int Index = cmbMentorList.SelectedIndex + 1;
                IList<Student> student = (from x in RegisterContext.Students
                                          where x.MentorID == Index
                                          select x).ToList();
            
                studentsList.DataContext = student;

              
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);              
            }                       
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime picker = new DateTime();      
            using (RegisterDBEntities db = new RegisterDBEntities())
            {
                picker = (DateTime)datePicker.SelectedDate;
                IList<Student> student = (from x in db.Students
                                           from d in db.AttendanceDetails
                                           where d.AttendanceDate == picker && x.ID == d.StudentID
                                           select x).ToList();
                studentsList.ItemsSource = student;
                
            }
        }
        private void studentsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int id = studentsList.SelectedIndex;
            this.StudentDetails();
        }
        private void studentsList_Loaded(object sender, RoutedEventArgs e)
        {          
        }
        private  IList<AttendanceDetail>  StudentDetails()
        {

            IList<AttendanceDetail> details = (from d in RegisterContext.AttendanceDetails
                                             
                                               select d).ToList();            
            attendanceDetails.ItemsSource = details;
            return details;
        }    
        private void studentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.StudentDetails(this.studentsList.SelectedItem as Student);                 
        }
        private void attendanceDetails_Loaded(object sender, RoutedEventArgs e)
        {         
        }     
        private void editStudent(Student student)
        {
            StudentForm sf = new StudentForm();
            sf.Title = "Edit Student Details";
            sf.txtFirstName.Text = student.FirstName;
            sf.txtLastname.Text = student.LastName;
            sf.txtEmail.Text = student.Email;
            sf.txtNumber.Text = student.Phone;
            sf.txtHome_Address.Text = student.Home_Address;
            sf.dtPicker.SelectedDate = student.DateOfBirth;
            if (sf.ShowDialog().Value)
            {
                student.FirstName = sf.txtFirstName.Text;
                student.LastName = sf.txtLastname.Text;
                student.Email = sf.txtFirstName.Text;
                student.Home_Address = sf.txtHome_Address.Text;
                student.Phone = sf.txtNumber.Text;
                student.DateOfBirth = (DateTime)sf.dtPicker.SelectedDate;

                btnSave.IsEnabled = true;
            }
        }
        private void removeStudent(Student student)
        {             
            try
            {
                MessageBoxResult response = MessageBox.Show(
              String.Format("Remove {0}", student.FirstName + " " + student.LastName),
              "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question,
              MessageBoxResult.No);
                if (response == MessageBoxResult.Yes)
                {
                    this.RegisterContext.Students.Attach(student);
                    this.RegisterContext.Students.Remove(student);
                    this.RegisterContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("User not Deleted" + ex.Message);
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {                         
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {           
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            removeStudent(this.studentsList.SelectedItem as Student);
           
            this.RegisterContext.SaveChanges();
            
                     
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }
    }
}
