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

namespace T3_Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTask21_Click(object sender, RoutedEventArgs e)
        {
            Task2 task2Window = new Task2(); // создание модального окна для задания 2
            task2Window.ShowDialog();
        }

        private void btnTask313_Click(object sender, RoutedEventArgs e)
        {
            var task3Window = new Task3();
            task3Window.ShowDialog();
        }
    }
}
