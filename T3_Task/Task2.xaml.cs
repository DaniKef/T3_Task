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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbxScheduleListFirst.Items.Clear(); // очистка листбокс
            lbxScheduleListSecond.Items.Clear();
            if(!tbxDayBegin.Text.Contains(':') || string.IsNullOrWhiteSpace(tbxDayBegin.Text) || string.IsNullOrWhiteSpace(tbxLessonDuration.Text) ||
                string.IsNullOrWhiteSpace(tbxUsualBreak.Text) || string.IsNullOrWhiteSpace(tbxBigBreak.Text) || string.IsNullOrWhiteSpace(tbxWhenBigBreak.Text) ||
                 string.IsNullOrWhiteSpace(tbxHowMuchLessons.Text) || Int32.Parse(tbxHowMuchLessons.Text) > 8) // проверка корректности введенных данных
            {
                MessageBox.Show("Заполните поля правильно!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning); //предупреждение
            }
            else
            {
                WorkingDay.SetWorkingDayValues(tbxDayBegin.Text, Int32.Parse(tbxLessonDuration.Text), Int32.Parse(tbxUsualBreak.Text), //вызов стат. метода, передаются значения с элементов
     Int32.Parse(tbxBigBreak.Text), Int32.Parse(tbxWhenBigBreak.Text), Int32.Parse(tbxHowMuchLessons.Text));
                if(WorkingDay.beginOfDayMinute>60) // проверка
                {
                    MessageBox.Show("Заполните поля правильно!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                WorkingDay.GetSchedule(lbxScheduleListFirst, lbxScheduleListSecond); // вызов метода, чтоб получить расписание
            }
        }
    }
}

