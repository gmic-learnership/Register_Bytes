﻿using System;
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
        public StudentForm()
        {
            InitializeComponent();
        }
        private void ok_Click(object sender, RoutedEventArgs e)
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
            else

            {
                this.DialogResult = true;
                btnOhk.IsEnabled = true;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {                
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();      
                                      
        }           
    }
}

