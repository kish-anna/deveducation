using HomeWork1;
using HomeWork2;
using HomeWork3;
using HomeWork4;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework1 hw1 = new Homework1();
            Console.WriteLine("1. Поменяйте содержимое переменных a и b местами.");
            hw1.VariablesTask1();
            Console.WriteLine("\n2. Найти длину гипотенузы");
            hw1.VariablesTask2();
            Console.WriteLine("\n3.Решение линейного уравнения A*X+B=C.");
            hw1.VariablesTask3();
            Console.WriteLine("\n1. Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B");
            hw1.Conditions1();
            Console.WriteLine("\n2. Проверить, делится ли первое на второе");
            hw1.Conditions2();
            Console.WriteLine("\n3. Определить, какой четверти принадлежит точка с координатами (x, y).");
            hw1.Conditions3();
            Homework2 hw2 = new Homework2();
            Console.WriteLine("\n1. Решение квадратного уравнения AX2+BX+C=0");
            hw2.Conditions1();
            Console.WriteLine("\n2. Выведите в консоль прописную запись этого числа.");
            hw2.Conditions2();
            Console.WriteLine("\n3. Определение принадлежности точки кругу с центром в начале координат");
            hw2.Conditions3();
            Console.WriteLine("\n1. Возвести число A в степень B.");
            hw2.Loop1();
            Console.WriteLine("\n2. Вывести все числа от 1 до 1000, которые делятся на A.");
            hw2.Loop2();
            Console.WriteLine("\n3. Докажите, что для множества натуральных чисел верно 1+2+...+n = n*(n+1)/2");
            hw2.Loop3();
            Console.WriteLine("\n4. Выведите N-ое число ряда Фибоначчи.");
            hw2.Loop4();
            Console.WriteLine("\n5.Вывести наибольший делитель (кроме самого A) числа A.");
            hw2.Loop5();
            Console.WriteLine("\n1. Заполните массив случайными числами");
            hw2.Array1();
            Console.WriteLine("\n2. Найдите наибольший элемент массива и его индекс.");
            hw2.Array2();
            Console.WriteLine("\n3. Посчитайте сумму элементов этого массива с нечетными индексами.");
            hw2.Array3();
            Console.WriteLine("\n4. Найдите в массиве те элементы, значение которых меньше среднего арифметического.");
            hw2.Array4();
            Console.WriteLine("\n5.Сделайте реверс массива (расположите элементы массива в обратном порядке.");
            hw2.Array5();
            Homework3 hw3 = new Homework3();
            Console.WriteLine("\n1. Есть ли в написании введенных чисел одинаковые цифры.");
            hw3.Loop1();
            Console.WriteLine("\n1. Зеркальное отображение последовательности.");
            hw3.Loop2();
            Console.WriteLine("\n1. Сложить, вычесть, умножить или делить два числа.");
            hw3.Loop3();
            Console.WriteLine("\n1. Поменять местами первую и вторую половину массива.");
            hw3.Array1();
            Console.WriteLine(
                "\n1. В массиве найти сумму элементов, находящихся между минимальным и максимальным элементами.");
            hw3.Array2();
            Console.WriteLine(
                "\n1. Посчитать, сколько раз встречается определенная цифра в введенной последовательности чисел.");
            hw3.Nloop1();
            Console.WriteLine("\n1. Вывести на экран прямоугольник, образованный из двух видов символов.");
            hw3.Nloop2();
            Console.WriteLine("\n1. Заполнить массив случайными числами");
            hw3.Darray1();
            Console.WriteLine("\n1. Вывести полученный массив в консоль");
            hw3.Darray2();
            Console.WriteLine(
                "\n1. Найти количество элементов массива, которые больше своих левого, правого, верхнего и нижнего соседа одновременно.");
            hw3.Darray3();
            Homework4 hw4 = new Homework4();
            Console.WriteLine(
                "\n1. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.");
            hw4.Euclidean();
            Console.WriteLine(
                "\n2. Реализовать сортировку одномерного массива по возрастанию, используя метод сортировки выбором.");
            hw4.ArraySorting();
            Console.WriteLine("\n3. Сделать фитнес-калькулятор для бегемотиков. ");
            hw4.HippoCalculator();
            // Homework5 hw5 = new Homework5(new int[] { });
        }
    }
}