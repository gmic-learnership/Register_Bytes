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
        private IList<AttendanceMaster> GetCustomers()
        {
            try
            {
                using (RegisterDBEntities db = new RegisterDBEntities())
                {
                    IList<AttendanceMaster> _mentor = (from x in db.AttendanceMasters
                                                       select x).ToList();
                    return _mentor;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }         
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegisterContext = new RegisterDBEntities();
            cmbMentorList.SelectedIndex = 1;
            cmbMentorList.DataContext = this.GetCustomers();                 
        }
        private void cmbMentorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            datePicker.SelectedDate = null;
            try
            {
                int Index = cmbMentorList.SelectedIndex + 1;
                IList<Student> student = (from x in RegisterContext.Students
                                          where x.MentorID == Index
                                          select x).ToList();
                studentsList.DataContext = student;      
            }
            catch (Exception z )
            {
                MessageBox.Show(z.Message);              
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
         editStudent(this.studentsList.SelectedItem as Student);
        }
        private void studentsList_Loaded(object sender, RoutedEventArgs e)
        {          
        }
        private void studentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int studID = studentsList.SelectedIndex + 1;
            IList<AttendanceDetail> details = (from d in RegisterContext.AttendanceDetails
                                             
                                              select d).ToList();
            attendanceDetails.DataContext = details;
        }
        private void attendanceDetails_Loaded(object sender, RoutedEventArgs e)
        {         
        }
        private  void addnewStudent()
        {
            using (RegisterDBEntities db = new RegisterDBEntities())
            {
                StudentForm sf = new StudentForm();
                sf.Title = "New Student for Class ";
                if (sf.ShowDialog().Value)
                {
                    Student student = new Student();
                    student.FirstName = sf.txtFirstName.Text;
                    student.LastName = sf.txtLastname.Text;
                    student.Email = sf.txtEmail.Text;
                    student.Home_Address = sf.txtHome_Address.Text;
                    student.DateOfBirth = (DateTime)sf.dtPicker.SelectedDate;
                    student.MentorID = Convert.ToInt32(sf.cmbStudentMentor.SelectedValue.ToString());
                    student.Phone = sf.txtNumber.Text;
                    // this.teacher.Students.Add(newStudent);                    
                    db.Students.Add(student);
                }
            }
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
            sf.dtPicker.SelectedDate = student.DateOfBirth; // Format the date to omit the time element
            if (sf.ShowDialog().Value)
            {
                student.FirstName = sf.txtFirstName.Text;
                student.LastName = sf.txtLastname.Text;
                student.Email = sf.txtFirstName.Text;
                student.Home_Address = sf.txtHome_Address.Text;
                student.Phone = sf.txtNumber.Text;
                student.DateOfBirth = (DateTime)sf.dtPicker.SelectedDate;
            }
        }
        private void removeStudent(Student student)
        {
                MessageBoxResult response = MessageBox.Show(
                String.Format("Remove {0}", student.FirstName + " " + student.LastName),
                "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question,
                MessageBoxResult.No);          
            if (response == MessageBoxResult.Yes)
            {               
                this.RegisterContext.Students.Remove(student);
                this.RegisterContext.SaveChanges();                       
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {                         
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {        
            this.RegisterContext.SaveChanges();
            btnSave.IsEnabled = true;
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            removeStudent(this.studentsList.SelectedItem as Student);
            this.RegisterContext.SaveChanges();
          
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            addnewStudent();          
        }
    }
}
