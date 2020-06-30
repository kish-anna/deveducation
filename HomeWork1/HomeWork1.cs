using System;

namespace HomeWork1
{
    public class Homework1
    {
        public void VariablesTask1()
        {
            //1. Пользователь вводит 2 числа (a и b). Поменяйте содержимое переменных a и b местами.

            int a = GetNumber("Enter the number a : ");
            int b = GetNumber("Enter the number b : ");

            (a, b) = Swap(a, b);

            Console.WriteLine("\nNew a: {0}, New b: {1}", a, b);
        }

        public void VariablesTask2()
        {
            //2. Найти длину гипотенузы (по двум введенным пользователем катетам вычислить длину гипотенузы.)

            Console.WriteLine("Calculating hypotenuse in equsion a*a+b*b=c*c");

            double a = GetNumberDouble("Enter the number a : ");

            double b = GetNumberDouble("Enter the number b : ");

            double c = GetHypotenuse(a, b);

            Console.WriteLine($"\nHypotenuse: {c}");
        }

        public void VariablesTask3()
        {
            //3. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
            Console.WriteLine("Calculation of a linear equation A*X+B=C");

            double a = GetNumberDouble("Enter the number a : ");
            double b = GetNumberDouble("Enter the number b : ");
            double c = GetNumberDouble("Enter the number c : ");

            double x = CalculationEquation(a, b, c);

            Console.WriteLine($" x = {x}");
        }

        public void Conditions1()
        {
            //1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B
            int a = GetNumber("Enter the number A : ");
            int b = GetNumber("Enter the number B : ");
            int c = ConditionComparison(a, b);

            Console.WriteLine($"Answer : {c}");
        }

        public void Conditions2()
        {
            //2. Вводятся два целых числа. Проверить, делится ли первое на второе. Вывести на экран сообщение об этом, а также остаток (если он есть) и частное (в любом случае).
            //(рандом от - 100 до 100)

            (int a, int b) = GetRandomNumbers(-100, 100);

            Console.WriteLine("Number 1: {0} \nNumber 2: {1}", a, b);
            if (b == 0)
            {
                Console.WriteLine("Impossible to count! Number 2 is 0, try again");
            }

            if (a == 0)
            {
                Console.WriteLine("Your result 0!");
            }

            (int result1, int result2) = GetDivisionWithRemainder(a, b);
            Console.WriteLine($"Your result {result1}, remainder of division {result2}.");
        }

        public void Conditions3()
        {
            //3. Определить, какой четверти принадлежит точка с координатами (x, y). x и y - рандом от - 10 до 10
            (int x, int y) = GetRandomNumbers(-100, 100);
            Console.WriteLine("Number 1: {0} \nNumber 2: {1}", x, y);
            int coordinate = FindQuarter(x, y);

            switch (coordinate)
            {
                case 0:
                    Console.WriteLine("Oops we hit the center. Try again!");
                    return;
                case 1:
                    Console.WriteLine("I quarter");
                    return;
                case 2:
                    Console.WriteLine("II quarter");
                    return;
                case 3:
                    Console.WriteLine("III quarter");
                    return;
                case 4:
                    Console.WriteLine("IV quarter");
                    return;
                case 12:
                    Console.WriteLine("You are between the I and II quarters. Try again!");
                    return;
                case 34:
                    Console.WriteLine("You are between the III and IV quarters. Try again!");
                    return;
                case 23:
                    Console.WriteLine("You are between the II and III quarters. Try again!");
                    return;
                case 14:
                    Console.WriteLine("You are between the I and IV quarters. Try again!");
                    return;
            }
        }

        public int GetNumber(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public double GetNumberDouble(string message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public (int, int) Swap(int a, int b)
        {
            return (b, a);
        }

        public double GetHypotenuse(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                return 0;
            }

            return (Math.Sqrt(a * a + b * b));
        }

        public double CalculationEquation(double a, double b, double c)
        {
            return (c - b) / a;
        }

        public int ConditionComparison(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a < b)
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
        }

        public (int, int) GetRandomNumbers(int minValue, int maxValue)
        {
            Random rnd = new Random();
            int result1 = rnd.Next(minValue, maxValue);
            int result2 = rnd.Next(minValue, maxValue);
            return (result1, result2);
        }

        public (int, int) GetDivisionWithRemainder(int a, int b)
        {
            if (b == 0)
            {
                return (0, 0);
            }

            return (a / b, a % b);
        }

        public int FindQuarter(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (x == 0 && y > 0)
            {
                return 12;
            }
            else if (x == 0 && y < 0)
            {
                return 34;
            }
            else if (x < 0 && y == 0)
            {
                return 23;
            }
            else if (x > 0 && y == 0)
            {
                return 14;
            }
            else
            {
                return x > 0 ? (y > 0 ? 1 : 4) : (y > 0 ? 2 : 3);
            }
        }
    }
}