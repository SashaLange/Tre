int oper;
do
{
    Console.WriteLine("Выберите какую операцию вы хотите сделать: ");
    Console.WriteLine("\r\n1. Игра угадай число\r\n" +
                      "2. Таблица умножения\r\n" +
                      "3. Вывод делителей числа\r\n" +
                      "4. Выход из программы\r\n");


    oper = Convert.ToInt32(Console.ReadLine());
    switch (oper)
    {
        case 1:

            Random rand = new Random();
            int a = rand.Next(100);
            int count = 1;
            Console.WriteLine("Число от 0 до 100 загадано");
            Console.WriteLine("Введите число:");
            int b = Convert.ToInt32(Console.ReadLine());
            while (count <= 8)
            {
                if (a == b)
                {
                    Console.WriteLine("Компьютер загадал число" + b + "Поздравляю, вы угадали число");
                    break;
                }
                else
                {
                    count++;
                    if (count == 9)
                    {
                        Console.WriteLine("Число не отгано " + a);
                        break;
                    }
                    if (b < a)
                    {
                        Console.WriteLine("Число больше");
                    }
                    if (b > a)
                    {
                        Console.WriteLine("Число меньше");
                    }
                    Console.WriteLine("Число не угадано. Попытка " + count);
                    b = Convert.ToInt32(Console.ReadLine());
                }
            }
            break;

        case 2:

            for (int m = 1; m < 10; m++)
            {
                for (int c = 1; c < 10; c++)
                {
                    Console.Write("{0} ", m * c);
                    if (c == 9)
                    {
                        Console.WriteLine();
                    }
                }

            }
            break;
        case 3:
            Console.WriteLine("Введите любое число для разложение на множетели ");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int t = 1; t <= y; t++)
            {
                if (y % t == 0)
                    Console.WriteLine(t);
            }
            break;
        case 4:
            Console.WriteLine("Завершение программы.");
            break;
    }
} while (oper != 4);
