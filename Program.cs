using System;


namespace HW_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите масимальное число диапазона: ");
            int max = int.Parse(Console.ReadLine()); //Определяем длину диапазона
            Random r = new Random();
            int a = r.Next(0, max + 1); //Загадываем число

            Console.Write("Попробуйте угадать загаданное число: ");
            int num = int.Parse(Console.ReadLine()); //Запоминаем введенное пользователем число
            
            while (a != num)
            {
                if (a > num)  Console.WriteLine($"Загаданное число больше, попробуйте снова!");
                else  Console.WriteLine($"Загаданное число меньше, попробуйте снова!");
                Console.Write("Введите число: ");
                var newnum = Console.ReadLine(); //Получаем введенное значение
                if (newnum == String.Empty) break; //Выходим из цикла через пустую строку
                num = int.Parse(newnum); //Преобразовываем значение в число, если это не пустая строка
            }
            Console.WriteLine($"Загаданное число: {a}");
            Console.ReadLine();
        }
    }
}
