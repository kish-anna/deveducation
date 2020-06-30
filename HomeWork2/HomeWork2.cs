using System;
using System.Data;
using System.Diagnostics.Tracing;

namespace HomeWork2
{
    public class Homework2
    {

        public void Conditions1()
        {
            //1. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.

            Console.WriteLine("Calculation of a equation AX2+BX+C=0");

            double a = GetNumberDouble("Enter the number a : ");
            double b = GetNumberDouble("Enter the number b : ");
            double c = GetNumberDouble("Enter the number c : ");
            double d = GetDiscriminant(a, b, c);
            double[] result = GetRoots(a, b, d);

            switch (result.Length)
            {
                case 0:
                    break;
                default:
                    break;
            }

        }

        public void Conditions2()
        {
            //2. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.


            int a = GetNumber("Enter a two digit number a: ");
            string number = PrintTwoDigitNumber(a);


            if (number == "")
            {
                Console.WriteLine("Is not a two digit number!"); 
            }

            Console.WriteLine(number);

        }

        public void Conditions3()
        {
            //3. Определение принадлежности точки кругу с центром в начале координат: вводятся координаты (x;y) 
            //точки и радиус круга (r), определить, принадлежит ли данная точка кругу, если его центр находится в начале координат.
            //x и y - рандом от - 15 до 15, r - рандом от - 10 до 10


            int x = GetRandomNumbers(-10, 10);
            int y = GetRandomNumbers(-10, 10);
            int r = GetRandomNumbers(0, 10);
            Console.WriteLine($"x={x}, y={y}, r={r}");

            if (r < 0)
            {
                Console.WriteLine("Radius cannot be less than 0. Try again.");
                return;
            }

            if (PointInCircle(x, y, r))
            {
                Console.WriteLine("Point belongs to a circle");
                return;
            }
            Console.WriteLine("Point does not belong to the circle");
        }

        public void Loop1()
        {
            //1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            int a = GetNumber("Enter the number a : ");
            int b = GetNumber("Enter the number b : ");
            int result = GetRaiseToPower(a, b);

            Console.WriteLine($"{a}^{b} = {result}");
        }

        public void Loop2()
        {
            //2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

            int number = GetNumber("Введите делитель");
            if(number == 0)
            {
                Console.WriteLine("Делить на 0 нельзя");
                return;
            }
            int[] result = DoTaskLogic(number);
            PrintArray(result);

        }
        public void Loop3()
        {
            //3. Пользователь вводит число n. Докажите, что для множества натуральных чисел верно 1+2+...+n = n*(n+1)/2

            int n = GetNumber("Enter the number n : ");
            int result1 = SumOneToN(n);
            int result2 = GetEquation(n);


           Console.WriteLine($"1+2+...+n = {result1}, n*(n+1)/2 = {result2}");
        }

        public void Loop4()
        {
            //4. Пользователь вводит число n. Выведите N-ое число ряда Фибоначчи. 
            //В ряду Фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

            int n = GetNumber("Enter the number n : ");
            int current = 1;
            int previous = 1;
            int result = GetFibonacciNumber(n);

            Console.WriteLine($"Fibonacci number {result}");
        }
        public void Loop5()
        {
            //5. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

            int a = GetNumber("Enter the number A : ");
            int result = GetGreatestDivisor(a);

            Console.WriteLine($"Greatest divisor :{result}");
        }
        public void Array1()
        {
            //1. Заполните массив случайными числами (рандом от -100 до 100).

            PrintArray(GetRandomArray(-100, 100, 20));


        }
        public void Array2()
        {
            //2. Найдите наибольший элемент этого массива и его индекс.
            int[] array = GetRandomArray(-100, 100, 20);
            PrintArray(array);

            int maxIndex = FindMaxIndex(array);

            Console.WriteLine($"Max [{maxIndex}] {array[maxIndex]}");
        }
        public void Array3()
        {
            //3. Посчитайте сумму элементов этого массива с нечетными индексами.

            int[] array = GetRandomArray(-100, 100, 20);
            PrintArray(array);
            int sum = SumArrayOddIndex(array);

            Console.WriteLine(sum);
        }
        public void Array4()
        {
            //4. Найдите в массиве те элементы, значение которых меньше среднего арифметического, взятого от всех элементов массива.

            int size = GetNumber("Введите длину массива");
            int[] array = GetArray(size);
            int average = CalcAverage(array);
            int[] result = GetElementsThanAverage(array, average);
            PrintArray(result);
        }
        

       
        
        public int[] GetArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
                
            {
                array[i] = GetRandomNumbers(0, 100);
            }

            return array;


        }

        public int CalcAverage(int[] array)
        {
            if(array.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public int[] GetElementsThanAverage(int[] array, int averge)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < averge)
                {
                    counter++;
                }
                
            }
            int[] resultArray = new int[counter];
            counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < averge)
                {
                    resultArray[counter] = array[i];
                    counter++;
                }
            }
            return resultArray;
        }


        public void Array5()
        {
            //5. Сделайте реверс массива (расположите элементы массива в обратном порядке - последний становится первым, предпоследний - вторым, и т.д.)

            int[] array = GetRandomArray(-100, 100, 20);
            PrintArray(array);
            
            Console.WriteLine("Reverse array: ");
            PrintArray(ReverseArray(array));
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
        public int[] ReverseArray(int[] array)
        {
            int[] reverse = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverse[i] = array[array.Length - i - 1];

            }
            return reverse;


        }
        public double GetDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;



        }
        public double[] GetRoots(double a, double b, double d)
        {
            if (d < 0)
            {

                return new double[] { };
            }
            else if (d == 0)
            {
                return new double[] { -b / (2 * a) };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }


        public string PrintTwoDigitNumber(int a)
        {
            if (a > 99 || a < 10)
            {
                return "";

            }

            switch (a)
            {
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
                default:
                    int First = a / 10;
                    int Second = a % 10;
                    string Number = "";

                    switch (First)
                    {
                        case 2:
                            Number = "Twenty";
                            break;
                        case 3:
                            Number = "Thirty";
                            break;
                        case 4:
                            Number = "Forty";
                            break;
                        case 5:
                            Number = "Fifty";
                            break;
                        case 6:
                            Number = "Sixty";
                            break;
                        case 7:
                            Number = "Seventy";
                            break;
                        case 8:
                            Number = "Eighty";
                            break;
                        case 9:
                            Number = "Ninety";
                            break;

                    }
                    switch (Second)
                    {
                        case 1:
                            Number += " one";
                            break;
                        case 2:
                            Number += " two";
                            break;
                        case 3:
                            Number += " three";
                            break;
                        case 4:
                            Number += " four";
                            break;
                        case 5:
                            Number += " five";
                            break;
                        case 6:
                            Number += " six";
                            break;
                        case 7:
                            Number += " seven";
                            break;
                        case 8:
                            Number += " eight";
                            break;
                        case 9:
                            Number += " nine";
                            break;
                    }
                    return Number;

            }
        }
        public int GetRandomNumbers(int minValue, int maxValue)
        {
            Random rnd = new Random();
            return rnd.Next(minValue, maxValue);

        }

        public bool PointInCircle(int x, int y, int r)
        {

            double g = Math.Sqrt(x * x + y * y);

            return g < r;
        }
        public int GetRaiseToPower(int a, int b)
        {
            int result = 1;
            while (0 < b)
            {
                b--;
                result = result * a;

            }

            return result;

        }

        public void PrintOneDimArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }


        public int[] DoTaskLogic(int number)

        {
            if (number == 0)
            {
                return new int[] { };
            }
            int counter = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                    counter++;
            }
            int[] resultArray = new int[counter];
            counter = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    resultArray[counter] = i;
                    counter++;
                }
            }
            return resultArray;

        }

        public int SumOneToN(int n)
        {
            int result = 0;
            int i = 0;
            do
            {
                result = result + i++;
            }
            while (n >= i);
            return result;
        }

        public int GetEquation(int n)
        {
            return (n * (n + 1) / 2);
        }

        public int GetFibonacciNumber(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n > 2 && n < 47)
            {
                int a = 1;
                int b = 1;
                int result = a + b;
                for (int i = 0; i < n - 2; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                return result;
            }

            return 0;

        }

        public int GetGreatestDivisor(int a)
        {

            if (a < 0)
            {
                return -a;

            }
            else if (a == 0)
            {
                return Int32.MaxValue;
            }
            int i = a - 1;
            while (i > 0)
            {

                if (a % i == 0)
                {
                    return i;
                }
                i--;
            }
            return 1;
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
        public int FindMaxIndex(int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[max] < array[i])
                {
                    max = i;
                }

            }
            return max;
        }
        public int SumArrayOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }

    }
}
