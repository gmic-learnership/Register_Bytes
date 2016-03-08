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
using System.Data.Objects;
using Rectify.Data.ViewModel;

namespace Rectify
{
    /// <summary>
    /// Interaction logic for Manage.xaml
    /// </summary>
    public partial class Manage : Window
    {
        public Manage()
        {
            InitializeComponent();
        }
        //    private RegisterDBEntities registerContext = null;
        //    private void Window_Loaded(object sender, RoutedEventArgs e)
        //    {
        //        studentsList.ItemsSource = GetStudentList();
        //        Name.Text = "Welcome," + SessionContext.UserName;
        //        Student student = this.studentsList.SelectedItem as Student;
        //        attendanceDetails.ItemsSource = getAttendanceByID(student.ID);
        //    }
        //    private List<Student> GetStudentList()
        //    {
        //        using (registerContext = new RegisterDBEntities())
        //        {
        //            List<Student> student = (from x in registerContext.Students
        //                                     select x).ToList();
        //            return student;
        //        }
        //    }
        //    public  IList<AttendanceDetail1> getAttendanceByID(int id)
        //    {
        //        try
        //        {
        //            using (registerContext = new RegisterDBEntities())
        //            {
        //                IList<AttendanceDetail1> details = (from x in registerContext.AttendanceDetail1
        //                                                    where x.StudentID == id
        //                                                    select x).ToList();
        //                return details;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }
        //    }
        //    private void studentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //    {
        //        Student student = this.studentsList.SelectedItem as Student;
        //        attendanceDetails.ItemsSource = getAttendanceByID(student.ID);
        //        txtTotal.Text = "No. of day(s) Attendant " + attendanceDetails.Items.Count.ToString();
        //    }
        //    private void btnDelete_Click(object sender, RoutedEventArgs e)
        //    {

        //    }
        //    private void btnAdd_Click(object sender, RoutedEventArgs e)
        //    {
        //        StudentForm add = new StudentForm();
        //        add.Show();
        //        this.Close();
        //    }
        //    private void run_MouseEnter(object sender, MouseEventArgs e)
        //    {
        //        popLink.IsOpen = true;
        //    }
        //    private void lnk_Click(object sender, RoutedEventArgs e)
        //    {
        //        popLink.IsOpen = false;
        //        Login login = new Login();
        //        login.Show();
        //        this.Hide();
        //    }
        //    private void btnback_Click(object sender, RoutedEventArgs e)
        //    {
        //        Home home = new Home();
        //        home.Show();
        //        this.Hide();
        //    }
        //    private void Hyperlink_Click(object sender, RoutedEventArgs e)
        //    {
        //        popLink.IsOpen = false;
        //        About about = new About();
        //        about.Show();
        //        this.Hide();
        //    }
        //    private void studentsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //    {
        //        Student student = this.studentsList.SelectedItem as Student;
        //        MessageBoxResult reponse = MessageBox.Show(string.Format("Remove", student.FirstName + "-" + student.LastName),
        //            "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

        //        if (reponse == MessageBoxResult.Yes)
        //        {
        //            SignModel sign = new SignModel();
        //            sign.DeleteLearner(student.ID);              
        //        }
        //        this.Show();
        //    }

        //    private void btnAddMentor_Click(object sender, RoutedEventArgs e)
        //    {
        //        Mentor mentor = new Mentor();
        //        mentor.Show();
        //        this.Hide();

        //    }
        //}
    }
}
