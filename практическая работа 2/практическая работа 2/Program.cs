using System.Net.Http.Json;
using System.Numerics;
using System.Text.Json.Serialization;

namespace практосномер2
{
    internal class Programm
    {
        public static int BoxS;
        static void Main()
        {
            Start();
            BoxS = Convert.ToInt32(Console.ReadLine());

            SelectedCase(BoxS);
        }

        public static void Start()
        {
            Console.WriteLine("Менюшечка \n" +
                "1. Игра угадай число если сможешь  \n" +
                "2. Таблица умножения для второклассника \n" +
                "3. Вывод делителей числа  \n" +
                "4. Прощание с лучшей программой которую вы когда либо видели) \n" +
                "Введите число");
        }

        public static void SelectedCase(int Code)
        {

            switch (Code)
            {
                case 1:
                    Console.Title = "Угадай число если сможешь";
                    Random SluchainoeChislo = new Random();
                    string ar0ni1;
                    int SecretnoeChislo = SluchainoeChislo.Next(101);
                    Console.WriteLine("Доброго времени суток, я загадал число от 1 до 100. Попробуй угадать,если смоежешь.");
                    while (true)
                    {
                        Console.WriteLine("Введите чсило");
                        ar0ni1 = Console.ReadLine();
                        if (!int.TryParse(ar0ni1, out int userNum))
                        {
                            continue;
                        }
                        if (userNum == SecretnoeChislo)
                        {
                            Console.WriteLine("Респект ты лучший");
                            break;
                        }
                        if (userNum < SecretnoeChislo)
                            Console.WriteLine("Неудача, попробуй взять больше");
                        else
                        {
                            Console.WriteLine("Неудача, попробуй число поменьше");
                        }
                    }


                    Start();
                    BoxS = Convert.ToInt32(Console.ReadLine());
                    SelectedCase(BoxS);
                    break;
                case 2:
                    int tableSize = 10;
                    Console.Write("   |");
                    for (int i = 1; i <= tableSize; i++)
                    {
                        Console.Write("{0,4}", i);
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('-', tableSize * 5 + 4));
                    for (int i = 1; i <= tableSize; i++)
                    {
                        Console.Write("{0,3}|", i);
                        for (int j = 1; j <= tableSize; j++)
                        {
                            Console.Write("{0,4}", i * j);
                        }
                        Console.WriteLine();
                    }
                    Start();
                    BoxS = Convert.ToInt32(Console.ReadLine());
                    SelectedCase(BoxS);
                    break;
                case 3:
                    bool exit = false;
                    do
                    {
                        Console.WriteLine("Введите число делимое которого вы хотите узнать, если вы хотите выйти-напишите,я поставлю тебе 5");
                        string input = Console.ReadLine();

                        if (input == "я поставлю тебе 5")
                        {
                            break;
                        }

                        int delitel = int.Parse(input);
                        string result = "";
                        for (int delimoe = 1; delimoe <= delitel; delimoe++)
                        {
                            if (delitel % delimoe == 0)
                            {
                                result += delimoe + " ";
                            }
                        }
                        Console.WriteLine(result);
                    
                    } while (!exit);

                    Start();
                    BoxS = Convert.ToInt32(Console.ReadLine());
                    SelectedCase(BoxS);
                    break;
                case 4:
                    Console.WriteLine("Поставьте 5 пожалуйста, всего хорошего)))))))");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
