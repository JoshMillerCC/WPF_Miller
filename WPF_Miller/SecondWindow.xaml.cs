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
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Go_To_Third_Window(object sender, RoutedEventArgs e)
        {
            var window = new ThirdWindow();
            this.Close();
            window.ShowDialog();
        }

        private void Go_To_First_Window(object sender, RoutedEventArgs e)
        {
            var window = new FirstWindow();
            this.Close();
            window.ShowDialog();
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
