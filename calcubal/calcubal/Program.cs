using System;

namespace calcubal
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = -1;
            int operand2 = -1;
            int operation = -1;

            Console.WriteLine("Привет! Я калькулятор положительных чисел Calcubal. Погоняй меня!\nДля окончания жми 'q'!\n");

            //var test3 = Console.ReadLine();
            //Console.WriteLine(int.Parse(test3));


            while (true)
            {
 
                //-------------------------
                Console.WriteLine("-------- Начало ---------\nВведите ПЕРВОЕ число: ");
                operand1 = Console.Read();
                if(operand1 != 113)  // q - 113
                {
                    operand1 = operand1 - 48;
                    //Console.WriteLine($"Введен символ:'" + $"{(char)operand1}" + $"'");
                    Console.Read();  // вычитываем "перенос строки" - 13
                    Console.Read(); // вычитываем "новую строку" - 10
                }
                else
                {
                    Console.WriteLine("\nЭто конец!");
                    break;
                }

                //-------------------------
                Console.WriteLine("Введите символ операции (+-*/): ");
                operation = Console.Read();
                if (operation != 113)  // q - 113
                {
                    //Console.WriteLine($"Введен символ:'" + $"{(char)operand1}" + $"'");
                    Console.Read();  // вычитываем "перенос строки" - 13
                    Console.Read(); // вычитываем "новую строку" - 10
                }
                else
                {
                    Console.WriteLine("\nЭто конец!");
                    break;
                }

                //-------------------------
                Console.WriteLine("Введите ВТОРОЕ число: ");
                operand2 = Console.Read();
                if (operand2 != 113)  // q - 113
                {
                    operand2 = operand2 - 48;
                    //Console.WriteLine($"Введен символ:'" + $"{(char)operand2}" + $"'");
                    Console.Read();  // вычитываем "перенос строки" - 13
                    Console.Read(); // вычитываем "новую строку" - 10
                }
                else
                {
                    Console.WriteLine("\nЭто конец!");
                    break;
                }

                //-------------------------
                switch (operation)
                {
                    case 43: Console.WriteLine($"Сумма=" + $"{operand1 + operand2}"); break;
                    case 45: Console.WriteLine($"Разница=" + $"{operand1 - operand2}"); break;
                    case 42: Console.WriteLine($"Умножение=" + $"{operand1 * operand2}"); break;
                    case 47: Console.WriteLine($"Деление=" + $"{operand1 / operand2}"); break;
                }
                Console.WriteLine("-------- Конец ---------");
            }
        }
    }
}
