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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Information(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MenuProgram\nАвтор - Колясников Никита");
        }

        private void White(object sender, RoutedEventArgs e)
        {
            windows.Background = new SolidColorBrush(Colors.White);
        }

        private void Blue(object sender, RoutedEventArgs e)
        {
            windows.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Green(object sender, RoutedEventArgs e)
        {
            windows.Background = new SolidColorBrush(Colors.Green);
        }

        private void Red(object sender, RoutedEventArgs e)
        {
            windows.Background = new SolidColorBrush(Colors.Red);
        }

        private void Yellow(object sender, RoutedEventArgs e)
        {
            windows.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void WindowFocus(object sender, MouseEventArgs e)
        {
            Focus.Text = "";
        }

        private void WindowEnter(object sender, MouseEventArgs e)
        {
            Focus.Text = "Изменение цвета";
        }

        private void InformationEnter(object sender, MouseEventArgs e)
        {
            Focus.Text = "Информация об авторе";
        }

        private void ExitEnter(object sender, MouseEventArgs e)
        {
            Focus.Text = "Закрытие приложения";
        }
    }
}
