namespace Calculator
{
    internal class Program
    {
        #region Functions
        //Метод "Add" возвращает суммму x и y
        static double Add(double x, double y)
        {
            return x + y;
        }
        //Метод "Sub" возвращает результат вычитания y из x
        static double Sub(double x, double y)
        {
            return x - y;
        }
        //Метод "Multiply" возвращает результат умножения x на y
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        //Метод "Div" возвращает результат деления x на y
        static double Div(double x, double y)
        {
            return x / y;
        }
        //Метод "Fact" возвращает факториал числа x
        static int Fact(int x)
        {
            int fact = 1;
            for (int i = 0; i < x; i++)
            {
                fact = fact + (fact * i);
            }
            return fact;
        }
        //Метод "Exp" возвращает результат возведения числа x в степень y
        static double Exp(double x, double y)
        {
            return Math.Pow(x, y);
        }
        //Метод "Percent" возвращает 1% от числа x
        static double Percent(double x)
        {
            return x / 100;
        }
        //Метод "Root" возвращает квадратный корень числа x
        static double Root(double x)
        {
            return Math.Sqrt(x);
        }
        #endregion;
        static void Main(string[] args)
        {
           
            
            //Изменение цвета текста консоли
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Добро пожаловать в простой калькулятор!");
            //Сброс цвета на цвет по умолчанию
            Console.ResetColor();
            //Основной цикл
            while (true)
            {
                Console.Write("1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление\n5.Вычесть факториал числа\n6.Возведение числа в N-ую степень\n7.Нахождение 1 процента от числа\n8.Нахождение квадратного корня из числа\n9.Выход из калькулятора\nВведите действие(Введите цифру(1-9)): ");
                char action = char.Parse(Console.ReadLine());
                if (action == '1')
                {
                    first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите первое число: ");
                    Console.ResetColor();
                    //Ввод первого числа
                    string first_number = Console.ReadLine();
                    
                    try
                    {
                        Convert.ToDouble(first_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                    second_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите второе число: ");
                    Console.ResetColor();
                    string second_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(second_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto second_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Результат сложения {first_number} + {second_number} = {Add(Convert.ToDouble(first_number),Convert.ToDouble(second_number))}");
                    Console.ResetColor();
                }
                else if (action == '2')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите первое число: ");
                    Console.ResetColor();
                    string first_number = Console.ReadLine();

                    try
                    {
                        
                        int.Parse(first_number);

                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                second_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите второе число: ");
                    Console.ResetColor();
                    string second_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(second_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto second_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Результат вычитания {first_number} - {second_number} = {Sub(Convert.ToDouble(first_number), Convert.ToDouble(second_number))}");
                    Console.ResetColor();
                }
                else if (action == '3')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите первое число: ");
                    Console.ResetColor();
                    string first_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(first_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                second_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите второе число: ");
                    Console.ResetColor();
                    string second_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(second_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto second_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Результат умножения {first_number} * {second_number} = {Multiply(Convert.ToDouble(first_number), Convert.ToDouble(second_number))}");
                    Console.ResetColor();
                }
                else if (action == '4')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите первое число(Делимое): ");
                    Console.ResetColor();
                    string first_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(first_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                second_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите второе число(Делитель): ");
                    Console.ResetColor();
                    string second_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(second_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto second_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Результат деления {first_number} / {second_number} = {Div(Convert.ToDouble(first_number), Convert.ToDouble(second_number))}");
                    Console.ResetColor();
                }
                else if (action == '5')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите число: ");
                    Console.ResetColor();
                    string number = Console.ReadLine();

                    try
                    {
                        Convert.ToInt32(number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите целое число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Факториал числа {number} = {Fact(Convert.ToInt32(number))}");
                    Console.ResetColor();
                   
                }
                else if (action == '6')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите первое число: ");
                    Console.ResetColor();
                    string first_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(first_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                second_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите степень в которую хотите возвести первое число: ");
                    Console.ResetColor();
                    string second_number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(second_number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto second_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Результат возведения числа {first_number} в степень {second_number} = {Exp(Convert.ToDouble(first_number), Convert.ToDouble(second_number))}");
                    Console.ResetColor();
                }
                else if (action == '7')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите число: ");
                    Console.ResetColor();
                    string number = Console.ReadLine();

                    try
                    {
                        Convert.ToInt32(number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"1% от числа {number} = {Percent(Convert.ToInt32(number))}");
                    Console.ResetColor();
                }
                else if (action == '8')
                {
                first_link: Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите число: ");
                    Console.ResetColor();
                    string number = Console.ReadLine();

                    try
                    {
                        Convert.ToDouble(number);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите число!");
                        Console.ResetColor();
                        goto first_link;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Квадратный корень числа {number} = {Root(Convert.ToDouble(number))}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("------До свидания!------");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}