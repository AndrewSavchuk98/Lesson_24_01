using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   int number = 0;

            bool isSuccess = false;

            string text = "Hello";

            char symbol = 'a';

            float numberDote = 1.5f;

            double numberDote2 = 2.7;

            System.Console.WriteLine(numberDote);

            System.Console.WriteLine(numberDote);


            int a = Convert.ToInt32(System.Console.ReadLine());
            int b = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine(a + b);

            if (a == b)
            {
                System.Console.WriteLine("Equal");
            } else if (b > a)
            {
                System.Console.WriteLine("b > a");
            }
            else
            {
                System.Console.WriteLine("b < a");
            }
            int c = 0;

            System.Console.WriteLine("Enter symbol ");
            symbol = Convert.ToChar(System.Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
            }
            System.Console.WriteLine(c);*/

           /* int[] array = { 1, 5, 5, 8, 10 };

            System.Console.WriteLine("Size " + array.Length);

            array[0] = 8;

            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");

            }
*/

           /* int j = 0;
            while (j < 100)
            {
                System.Console.WriteLine(j);
                j++;
            }*/

            // Максимальне і мінімальне число в масиві

            // Суму всіх елементів масива

            // Добуток тільки парних елементів масива

            // a % 2 == 0

            // Відсортувати масив
/*
            int max = array[0];
            int min = array[0];
            int sum = 0;
            int multiply = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];

                if (array[i] % 2 == 0)
                {
                    multiply *= array[i];
                }
            }
            System.Console.WriteLine("Max: " + max);    
            System.Console.WriteLine("Min: " + min);    
            System.Console.WriteLine("Sum: " + sum);    
            System.Console.WriteLine("Multiply: " + multiply);    
          
            // sort 

            for (int i = 0; i < array.Length; i++)
            {
                  for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            System.Console.Write("Sorted: ");
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");

            }
            System.Console.WriteLine();

            foreach (int item in array)
            {
                System.Console.WriteLine(item);
            }

            // { 0, 0, 0} 0 0
            // 0 0 0
            // 0 0 0

            int[,] doubleArray = { { 0, 0, 0}, { 5, 8, 7}, { 1, 2, 4} };

            System.Console.WriteLine(doubleArray[1, 1]);
*//*
            for (int i = 0; i < doubleArray.Length; i++)
            {
                System.Console.Write(doubleArray[0, i] + " ");
            }*//*

            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    System.Console.Write(doubleArray[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            string text = "Hello";
            foreach (char item in text)
            {
                System.Console.WriteLine(item);
            }

            Random random = new Random();

            string[] te = { "a" };
            int result  = random.Next(1, 100);*/

            //using System.Linq;

            //            "12354".Split(); -> { "1", "2", "3", "4", "5"}

            // res += i   -> 54321

            // Task1 Програма загадує випадкове число від 1 до 100, користувач намагається вгадати його.
            // Програма виводить підсказки Більше чи Менше

            // Task 2 Виведіть таблицю множення у вигляді матриці (таблиці)
            // 1 2 3  
            // 2 4 6
            // 3 6 9  ...

            // && - and
            // || - or

            // Task 3 Користувач вводить рядок, а програма рахує кільтість голосних в цьому рядку (а, е, є, і, ї, о, у, я)

            // Task 4 Знайти суму чисел в заданому діапаозоні який вводить користувач
            // Наприклад користувач ввів 5 і 8  (5 + 6 + 7 + 8) = 26, якщо користувач вводить однаковий діапазон, наприклад 10 і 10
            // то попросити його ввести новий

            // Task 5. Реверс числа.  користувач вводить число 584921 отримуємо 129485

            string numberText = "584921";

            /*string[] numbers = numberText.Split();*/

            //System.Console.WriteLine(numbers.Length);
            string newNumberText = "";
            for (int i = numberText.Length - 1; i >= 0; i--)
            {
                System.Console.Write(numberText[i]);
                
            }

        

        }
    }
}
