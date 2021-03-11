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
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }

        private void Go_To_Second_Window(object sender, RoutedEventArgs e)
        {
            var window = new SecondWindow();
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
