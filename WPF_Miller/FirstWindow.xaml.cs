using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Miller
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Go_To_Second_Window(object sender, RoutedEventArgs e)
        {
            var window = new SecondWindow();
            this.Close();
            window.ShowDialog();
        }

        private void Go_To_Third_Window(object sender, RoutedEventArgs e)
        {
            var window = new ThirdWindow();
            this.Close();
            window.ShowDialog();
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
