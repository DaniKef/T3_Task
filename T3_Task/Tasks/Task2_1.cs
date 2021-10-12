// Гуренко Даниил
// Вариант 5
//Задание 2.1
//В учебном заведении задается начало учебного дня, продолжительность урока, 
//длительность обычной и большой перемены (и место большого перерыва в расписании), 
//количество уроков.Вывести расписание звонков на весь учебный день(часы, минуты).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace T3_Task.Tasks
{
    static class WorkingDay
    {
        static public string beginOfDay; // начало дня
        static public int beginOfDayHour; // начало дня(часы)
        static public int beginOfDayMinute; // начало дня(минуты)
        static public int lessonDuration; // длительность урока
        static public int usualBreak; // обычный перерыв
        static public int bigBreak; // большой перерыв
        static public int whereBigBreak; // после какого урока большой перерыв
        static public int numberOfLessons; // сколько уроков 
        static public void ConverStringDayToInt() // разбить для счета минуты и часы beginOfDay, которые ввел человек
        {
            string[] words = beginOfDay.Split(new char[] { ':' });
            beginOfDayHour = Int32.Parse(words[0]); // сюда час (число до :)
            beginOfDayMinute = Int32.Parse(words[1]);// сюда минуту (число после :)
        }
        static public void GetSchedule(ListBox beginList, ListBox finalList) // Получить расписание предметов
        {
            int t1 =beginOfDayHour; // временная переменна часа
            int t2 =beginOfDayMinute; // временная переменная минуты
            for (int i = 0; i < numberOfLessons; i++) // проходит с 1 до последнего урока
            {
                beginList.Items.Add(t1.ToString()+" : " + t2.ToString());
            t2 += lessonDuration; // к минутам + длительность урока
            if (t2 >= 60) // если минут > 60 - начался новый час
                {
                    t2 -= 60; // -60 минут
                    t1 += 1; // +1 час
                }
               finalList.Items.Add(t1.ToString() + " : " + t2.ToString());
                if ((i + 1) == whereBigBreak) t2 += bigBreak; // если время для большой перемены + время большой перемены
                else t2 += usualBreak; // всегда добавляет время обычной перемены
                if (t2 >= 60) // еще раз проверка, чтоб переносить минуты и часы
                {
                    t2 -= 60;
                    t1 += 1;
                }
            }
        }
        static public void SetWorkingDayValues(string beginDay, int lesDur, int usBreak, int bgBreak, int whereBreak, int numLes) // Чтоб пользователь присвоил значения 
        {
            beginOfDay = beginDay;
            ConverStringDayToInt();// вызов метода, чтоб разделить минуты и часы
            lessonDuration = lesDur;
            usualBreak = usBreak;
            bigBreak = bgBreak;
            whereBigBreak = whereBreak;
            numberOfLessons = numLes;
        }
    }
}
