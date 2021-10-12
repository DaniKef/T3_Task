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
using T3_Task.Tasks;
namespace T3_Task
{
    /// <summary>
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbInputString.Text)) // проверка ввода
            {
                MessageBox.Show("Заполните поля правильно!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string finalValue = new string(StringSortClass.StringSort(txbInputString.Text.ToCharArray())); //передача введенной строки
                txbFinalString.Text = finalValue; // присвоение отсортированной строки
            }
        }
    }
}
