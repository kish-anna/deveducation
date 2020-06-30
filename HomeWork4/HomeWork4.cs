using System;

namespace HomeWork4
{
    public class Homework4
    {

        public void Euclidean()
        {
            //1. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            int a = GetNumber("Enter the number : ");
            int b = GetNumber("Enter the number : ");
            int result = GetEuclideanAlgorithm(a, b);

            Console.WriteLine($"Greatest common factor : {result}");
        }
        public void ArraySorting()
        {
            //2. Реализовать сортировку одномерного массива по возрастанию, используя метод сортировки выбором (последние 10-15 минут занятия от 12.06)
            int length = GetNumber("Enter the length of the array : ");
            int[] array = GetRandomArray(-100, 100, length);
            PrintArray(array);
            Console.WriteLine("Sorted: ");
            int[] sortedArray = Sort(array);
            PrintArray(sortedArray);

        }
        public void HippoCalculator()
        {
            

            int calories = 0;
            do
            {
                Console.WriteLine("Я бегемотик.\n Что мне делать?:  "); 
                int make = GetNumber("0. Выйти 1. Покушать 2. Поиграть : ");

                switch (make)
                {
                    case 0:
                        Console.WriteLine("End");
                        return;
                    case 1:
                        make = GetNumber("Что мне скушать? \n 3. Трава 4. Водоросли 5. Вкусных сочных молодых австралийских крокодилов");
                        break;
                    case 2:
                        make = GetNumber("Во что поиграть? \n 6. Прятки 7. Догонялки на выживание 8. Шахматы 9. Dota2");
                        break;
                    default:
                        continue;


                }
                    
                
                int howMuch = GetNumber("Сколько?");

                calories = CountingCalories(calories, make, howMuch);
                int fat = CaloriesToFat(calories);

                Console.WriteLine($"Калории : {calories}, Жир : {fat}");


            }
            while (true);

        }

        public int GetNumber(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());

        }

        public int GetEuclideanAlgorithm(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return 0;
            }
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
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

        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int c = array[i];
                array[i] = array[min];
                array[min] = c;
            }
            return array;
        }

        public int CountingCalories(int calories, int make, int howMuch)
        {

            switch (make)

            {
                case 3:
                    return calories += 21 * howMuch;

                case 4:
                    return calories += 32 * howMuch;
                case 5:
                    return calories += 54 * howMuch;
                case 6:
                    return calories += -132 * howMuch;
                case 7:
                    return calories += -432 * howMuch;
                case 8:
                    return calories += -67 * howMuch;
                case 9:
                    return calories;

            }
            return calories;
        }
        public int CaloriesToFat(int calories)
        {
            return calories / 30;
        }

    }
}
