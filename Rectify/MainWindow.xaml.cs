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
using System.Text.RegularExpressions;
using System.Globalization;
using Rectify.ModelData;

namespace Rectify
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Home home = null;
        private DigitalEntities digitalContext = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void GetMentors()
        {
            try
            {
                using (digitalContext = new DigitalEntities())
                {
                    List<Person> person = (from x in digitalContext.People
                                           where x.RoleID == 2
                                           select x).ToList();
                    foreach (var item in person)
                    {
                        cmbMentorList.Items.Add(item.FirstName + "  " + item.LastName.Substring(0, 1).ToUpper());
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
            digitalContext = new DigitalEntities();
            SignModel sign = new SignModel();
            GetMentors();
            datePicker.SelectedDate = DateTime.Now;
            cmbStudent.SelectedIndex = 1;
            cmbMentorList.SelectedIndex = 1;
            Username.Text = "Welcome ," + SessionContext.UserName;
            LoadData();
            CustomViewModel model = new CustomViewModel();
            DateTime picker = (DateTime)datePicker.SelectedDate;
            item.DataContext = model.LoadData();
        }  
        private void LoadData()
        {
            
        }
        private void cmbMentorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int Index = cmbMentorList.SelectedIndex + 1;
                using (digitalContext = new DigitalEntities())
                {
                    List<Person> student = (from x in digitalContext.People
                                            where x.RoleID == 1
                                            select x).ToList();
                    cmbStudent.DataContext = student;
                    Index = cmbMentorList.SelectedIndex + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            listBox1.Items.Clear();
            combo.Items.Clear();
            DateTime picker = (DateTime)datePicker.SelectedDate;
            digitalContext = new DigitalEntities();
            var q = from a in digitalContext.AttendanceDetails
                    join b in digitalContext.People on new { a.PersonID } equals new { b.PersonID }
                    join c in digitalContext.AttendanceMasters on new { a.MasterID } equals new { c.MasterID }
                    where c.AttendanceDate == picker 
                    select new
                    {
                        b.FirstName,
                        a.HoursPerDay
                    };
            listBox1.Items.Add("Name" + "        "+ "   "  + "Hours");      
            foreach (var item in q)
            {
                listBox1.Items.Add(item.FirstName +"        " + item.HoursPerDay);
                combo.Items.Add(item.FirstName + "  " + item.HoursPerDay);
            }

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SignModel signModel = new SignModel();
                if (!Regex.IsMatch(txtHours.Text, "^((?:[0-9]|1[0-9]|2[0-3])(?:\\.\\d{1,2})?|24(?:\\.00?)?)$"))
                {
                    MessageBox.Show("Invalid input for Hours");
                    txtHours.Clear();
                }
                else
                {
                    AttendanceMaster master = new AttendanceMaster();
                    master.TrainedOn = txtTask.Text;
                    master.AttendanceDate = (DateTime)datePicker.SelectedDate;
                    MessageBox.Show(signModel.MasterRecord(master));
                    AttendanceDetail detail = new AttendanceDetail();
                    decimal hrs = decimal.Parse(txtHours.Text, CultureInfo.InvariantCulture);
                    detail.HoursPerDay = hrs;                 
                    detail.MasterID = master.MasterID;
                    MessageBox.Show(signModel.SignRegister(detail));
                    txtHours.Clear();
                    txtTask.Clear();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnNavigate()
        {
            this.Close();
            home = new Home();
            home.Show();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

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
            this.Hide();
            home = new Home();
            home.Show();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            popLink.IsOpen = false;
            About about = new About();
            about.Show();
            this.Hide();
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

