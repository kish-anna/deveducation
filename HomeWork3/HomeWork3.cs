using System;
using System.Globalization;

namespace HomeWork3
{
    public class Homework3
    {
        
        

        public void Loop1()
        {
            /*1. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            Например, для пары 123 и 345, ответом будет являться “ДА”, а, для пары 500 и 999 - “НЕТ”.*/

            int g = GetNumber("Enter the number A : ");
            int h = GetNumber("Enter the number h : ");
            string result = CheckSameNumbers(g, h);
            Console.WriteLine(result);

        }
        public void Loop2()
        {
            /* 2.Пользователь вводит 1 число.
                Найти число, которое является зеркальным отображением последовательности цифр заданного числа, 
                например, задано число 123, вывести 321.*/

            int a = GetNumber("Enter the number : ");
            int result = ExpandNumbers(a);


            Console.WriteLine($"Answer: {result}");
        }
        public void Loop3()
        {
            /*3. Написать программу, которая будет складывать, вычитать, умножать или делить два числа. 
                Числа и знак операции вводятся пользователем. 
                После выполнения вычисления программа не должна завершаться, а должна запрашивать новые данные для вычислений. 
                Завершение программы должно выполняться при вводе символа '0' в качестве знака операции. 
                Если пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об ошибке и снова запрашивать знак операции. 
                Также сообщать пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя.
                Что должно получиться в результате? 
                Я думаю, все представляют себе обычный калькулятор, где итог изначально равен 0. 
                Вам предстоит реализовать нечто подобное - где вы вводите число, а затем - знак операции, потом снова число, потом снова знак операции... 
                Естественно, стоит выводить в консоль промежуточные результаты вычислений.*/

            int a = GetNumber("Enter the number : ");
            

            do
            {
                Console.WriteLine("Set operation (+ - * /) :");
                string o = Console.ReadLine();
                if (o == "0")
                {
                    Console.WriteLine("End");
                    return;
                }
                if (!CheckOpiration(o) )
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                

                int b = GetNumber("Enter the number : ");



                if (CheckDivisionByZero(o, b))
                {
                    Console.WriteLine("Try again");
                    continue;
                }

                a = DoCalculations(o, a, b);
                Console.WriteLine($"Result : {a}");


            }
            while (true);


        }

        public void Array1()
        {
            /*1. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2. 
            Если в массиве кол-во элементов нечётное (1 2 3 4 5), “средний” элемент оставить на своём месте: 4 5 3 1 2*/

            int[] array = GetRandomArray(-100, 100, 20);
            PrintArray(array);
            
            Console.WriteLine("New Array : ");
            PrintArray(SwapArray(array));
        }
        public void Array2()
        {
            /*2. В массиве найти сумму элементов, находящихся между минимальным и максимальным элементами. 
             * Сами минимальный и максимальный элементы в сумму не включать.*/
            int[] array = GetRandomArray(-100, 100, 20);
            PrintArray(array);
            
            (int min, int max) = FindMaxMin(array);
            int sum = SumArray(array, min, max);
            int result = sum - max - min;



            Console.WriteLine($"Max {max}, Min {min}");
            Console.WriteLine($"Sum = {result}");

            

        }
        public void Nloop1()
        {
            /*1. Посчитать, сколько раз встречается определенная цифра в введенной последовательности чисел. 
             * Количество вводимых чисел и цифра, которую необходимо посчитать, задаются вводом с клавиатуры.*/

            int a = GetNumber("Enter the number : ");

            int[] array = GetRandomArray(-100, 100, a);
            PrintArray(array);

            
            int c = GetNumber("What figure will we look for: ");
            int result = FindNumber(c, array);



            Console.WriteLine($"Number {c} is repeated : {result} times");




        }
        public void Nloop2()
        {
            /*2. Вывести на экран "прямоугольник", образованный из двух видов символов. 
             * Контур прямоугольника должен состоять из одного символа, а в "заливка" - из другого. 
             * Размеры прямоугольника, а также используемые символы задаются вводом с клавиатуры.*/
            int a = GetNumber("Enter the number a: ");
            int b = GetNumber("Enter the number b: ");
            Console.WriteLine("Enter the symbol : ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter the symbol for frame : ");
            string symbolFrame = Console.ReadLine();
            PrintRectangle(a, b, symbol, symbolFrame);
           
        }
        public void Darray1()
        {
            //1. Заполнить массив случайными числами (рандом от -200 до 200)

           
            PrintTwoDimentionalArray(GetRandomTwoDimentionalArray(5, 5, -200, 200));

        }
        public void Darray2()
        {
            //2. Вывести полученный массив массив в консоль (так, чтобы получились ровные столбцы)

            PrintTwoDimentionalArray(GetRandomTwoDimentionalArray(5, 5, -200, 200));


        }
        public void Darray3()
        {
            /*3. Найти количество элементов массива, которые больше своих левого, правого, верхнего и нижнего соседа одновременно. 
             * Вывести эти элементы в консоль в формате [i, j] = x 
             * (вместо i - индекс строки, вместо j - индекс столбца, вместо х - значение элемента массива)*/


            int[,] array = GetRandomTwoDimentionalArray(5, 5, -200, 200);
            PrintTwoDimentionalArray(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   if (CompareArrayCells(i, j, array))
                    {
                        Console.WriteLine($"[{i}, {j}] = {array[i, j]}");
                    }
                }
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

        public string CheckSameNumbers(int g, int h)
        {

            while (g > 0)
            {
                int currentDigit = g % 10;
                g /= 10;
                Console.WriteLine($"сейчас сравниваем цифру {currentDigit}");
                int secontNumber = h;

                while (secontNumber > 0)
                {
                    int currentDigitB = secontNumber % 10;
                    secontNumber /= 10;
                    Console.WriteLine($"сейчас проверяем цифру {currentDigitB} числа b");

                    if (currentDigit == currentDigitB)
                    {
                        return "Ура! мы наконец-то нашли совпадение!";

                    }
                }

            }
            return "Совпадений нет!";
        }

        public int ExpandNumbers(int a)
        {
            int b = 0;
            do
            {
                b = b * 10 + (a % 10);
                a = a / 10;
            }
            while (a > 0);
            return b;
        }
        public bool CheckOpiration(string o)
        {
            if (o == "+" || o == "-" || o == "*" || o == "/")
            {
                return true;
            }
            return false;
        }
        public bool CheckDivisionByZero(string o, int b)
        {
            if (b == 0 && o == "/")
            {
                return true;
            }
            return false;


        }
        public int DoCalculations(string o, int a, int b)
        {


            switch (o)

            {

                case "+":
                    return a + b;

                case "-":
                    return a - b;

                case "*":
                    return a * b;

                case "/":
                    return a / b;

            }
            return a;


        }

        public int[] GetRandomArray(int minValue, int maxValue, int a)
        {
            Random rnd = new Random();

            int[] array = new int[a];

            for (int i = 0; i < a; i++)
            {
                array[i] = rnd.Next(-100, 101);


            }
            return array;
        }
        public void PrintArray(int[] array)
        {


            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine($"{array[i]}, {i}");

            }
        }
        public int[] SwapArray(int[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }
            int j = (array.Length + 1) / 2;
            int[] swap = new int[array.Length];


            for (int i = 0; i < array.Length / 2; i++)
            {

                swap[i] = array[j + i];
                swap[j + i] = array[i];

            }
            return swap;

        }
        public (int, int) FindMaxMin(int[] array)
        {
            if (array.Length == 0)
            {
                return (0, 0);
            }
            int max = 0;
            int min = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }

                if (array[min] > array[i])
                {
                    min = i;
                }
            }
            return (max, min);
        }

        public int SumArray(int[] array, int min, int max)
        {
            int sum = 0;

            if (array.Length < 3)
            {
                return 0;
            }

            if (max > min)
            {
                for (int i = min + 1; i < max; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
            for (int i = max + 1; i < min; i++)
            {
                sum += array[i];
            }
            return sum;


        }
        public int FindNumber(int c, int[] array)
        {
            int f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                while (array[i] > 0)
                {
                    if (array[i] % 10 == c)
                    {
                        f++;
                    }
                    array[i] = array[i] / 10;
                }
            }
            return f;
        }
        public string PrintRectangle(int a, int b, string symbol, string symbolFrame)
        {
            string k = "";
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    if (j == 0 || j == b - 1 || i == 0 || i == a - 1)
                    {
                        k += symbolFrame;
                    }
                    else
                    {
                        k += symbol;
                    }
                }
                k += "\n";
            }
            return k;
        }
        public void PrintTwoDimentionalArray(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("{0}\t", array[i, j]);

                }
                Console.WriteLine();
            }
        }
        public int[,] GetRandomTwoDimentionalArray(int rows, int cols, int minValue, int maxValue)
        {

            int[,] array = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(minValue, maxValue);

                }

            }
            return array;
        }
        public bool CompareArrayCells(int i, int j, int[,] array)
        {
            int k = array.GetLength(0) - 1;
            int m = array.GetLength(1) - 1;
            if (i == 0 && j == 0)
            {
                if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1])
                    return true;
            }
            else if (i == 0 && j == m)
            {
                if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1])
                    return true;
            }
            else if (i == k && j == 0)
            {
                if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1])
                    return true;
            }
            else if (i == k && j == m)
            {
                if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1])
                    return true;
            }
            else if (i == k && j == m)
            {
                if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1])
                    return true;
            }
            else if (i == 0)
            {
                if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1] && array[i, j] > array[i, j + 1])
                    return true;
            }
            else if (j == 0)
            {
                if (array[i, j] > array[i + 1, j] && array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1])
                    return true;
            }
            else if (j == m)
            {
                if (array[i, j] > array[i, j - 1] && array[i, j] > array[i - 1, j] && array[i, j] > array[i + 1, j])
                    return true;
            }
            else if (i == k)
            {
                if (array[i, j] > array[i, j - 1] && array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1])
                    return true;
            }
            else
            {
                if (array[i, j] > array[i, j - 1] && array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1] && array[i, j] > array[i + 1, j])
                    return true;
            }
            return false;
        }
    }
}
