using Tyuiu.DmiterkoKD.Sprint1.Task2.V11.Lib;
namespace Tyuiu.DmiterkoKD.Sprint1.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Дмитерко К.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в С#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Дмитерко Кира Дмитриевна | ИБКСб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Задано текущее время в часах и минутах.                                 *");
            Console.WriteLine("* Вычислить, сколько секунд прошло с начала суток.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int c, m;
            Console.WriteLine("Введите значение часов:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение минут:");
            m = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ConvertHoursMinutesToSeconds(c, m));
        }
    }
}
