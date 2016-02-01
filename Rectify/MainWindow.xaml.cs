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

namespace Rectify
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
            cmbMentorList.DataContext = this.GetCustomers();
        }

        private void cmbMentorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Index = cmbMentorList.SelectedIndex + 1;
            IList<Student> student = (from x in RegisterContext.Students
                                      where x.MentorID == Index
                                      select x).ToList();
            studentsList.DataContext = student;                     
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime picker = new DateTime();
            picker =(DateTime)datePicker.SelectedDate;
            AttendanceDetail userDetails = new AttendanceDetail();         
            IList<Student> student = (from x in RegisterContext.Students
                                               where userDetails.AttendanceDate == picker                                                                                         
                                               select x).ToList();
            studentsList.DataContext = student;
        }
        private void studentsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {          
        }
        private void studentsList_Loaded(object sender, RoutedEventArgs e)
        {        
        }
        private void studentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            int studentId = (int)studentsList.SelectedIndex;
            IList<AttendanceDetail> detais = (from d in RegisterContext.AttendanceDetails
                                              where d.ID == studentId
                                              select d).ToList();
            attendanceDetails.DataContext = detais;
        }
    }
}
