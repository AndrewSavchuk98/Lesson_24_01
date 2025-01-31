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

          /*  string numberText = "584921";

            *//*string[] numbers = numberText.Split();*//*

            //System.Console.WriteLine(numbers.Length);
            string newNumberText = "";
            for (int i = numberText.Length - 1; i >= 0; i--)
            {
                System.Console.Write(numberText[i]);
                
            }
*/
        
            /*int[] arr = new int[10];
            arr[0] = 1;
            for (int i = 0; i< arr.Length; i++)
            {
                System.Console.Write(arr[i]);

            }*/

/*            Random rand = new Random();

            rand.Next(2, 10);

            int[,] arr2 = new int[10, 10];
            //int[,] arr3 = { { 0, 0,0}, { 0} };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rand.Next(10);
                    System.Console.Write(arr2[i, j] + " ");
                    sum += arr2[i, j];
                }

                System.Console.WriteLine($" = {sum}");
                System.Console.WriteLine();
            }



            // 1 2 3  = 6
            // 2 3 4  = 9
            // 4 5 6  = 15

            // Списки в C#

            List<int> numbers = new List<int>();

            numbers.Add(35);
            numbers.Add(27);
            numbers.Add(15);
            numbers.Add(314);


            foreach (int i in numbers)
            {
                System.Console.WriteLine(i);
            }

            numbers.Remove(314);

            Console.WriteLine("******************");
            foreach (int i in numbers)
            {
                System.Console.WriteLine(i);
            }

            Console.WriteLine(numbers.Count);

            //numbers.Clear();

            numbers.RemoveAt(0);

            numbers.ForEach(i =>
                {
                    System.Console.WriteLine($" new = {i}");
                }
            ); 

            for (int i = 0; i < 5 ; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (int i in numbers)
            {
                System.Console.WriteLine(i);


            }

            System.Console.WriteLine("some".Count());*/
            // Task 1: Створити список імен, 
            // Далі користувач вводить 5 разів якесь ім'я, вам треба записати їх в список і вивести
            // Запрошений: Andrew, Запрошений: Leon 。。。
            // Знайдіть найдовше ім'я і порахуйте скільки в ньому літер

      /*      List<string> names = new List<string>();

            for(int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Enter name ");
                names.Add(Console.ReadLine());
            }

            string maxName = names[0];

            names.ForEach(name =>
            {
                System.Console.WriteLine(name);
                if (name.Length > maxName.Length)
                {
                    maxName = name;
                }

            });*/
/*
            System.Console.WriteLine($"Max  {maxName}");
            System.Console.WriteLine($"Size of {maxName} == {maxName.Length}");*/

    /*        List<int> numbers = new List<int>() { 1, 2, 5, 1 ,8};

            System.Console.WriteLine($"Index of {5} = {numbers.BinarySearch(124)}");

            int[] arr = new int[5];
            
            numbers.CopyTo(arr);*/
            
            //List<string> list = new List<string>();
/*
            list = numbers.GetRange(1, 2);

            list.Insert(0, 2555);
            list.Reverse(1, 2);
            list.Max();

            foreach (int i in list)
            {
                System.Console.WriteLine(i);

            }*/


      /*      for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                if (i == 2)
                {
                    list.Insert(0, name);
                }
                else
                {
                    list.Add(name);
                }
            }

*//*
            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                list.Add(name);
            }

            list.Insert(0, list[2]);
            list.RemoveAt(3);
*/

/*

            Console.WriteLine("*************");
            list.ForEach(x => Console.Write(x + " "));
            
            List<string> newList = list.GetRange(1, 3);
            
            Console.WriteLine("*************");
            newList.ForEach(x => Console.Write(x + " "));

            newList.RemoveAt(1);

            Console.WriteLine("*************");
            newList.ForEach(x => Console.Write(x + " "));

            newList.Reverse();

            Console.WriteLine("*************");
            newList.ForEach(x => Console.Write(x + " "));
            
            newList.Sort();

            Console.WriteLine("*************");
            newList.ForEach(x => Console.Write(x + " "));
*/


            // В М Д С Р 

            // Д В М С Р 
            /*
             *    Методи списку List:
             *    
             * void Add(T item) : додавання нового елемента до списку

                void AddRange(IEnumerable<T> collection) : додавання до списку колекції або масиву

                int BinarySearch(T item) : бінарний пошук елемента у списку.Якщо елемент знайдено, метод повертає індекс цього елемента в колекції.При цьому список має бути відсортований.

                void CopyTo(T[] array) : копіює список у масив array

                void CopyTo(int index, T[] array, int arrayIndex, int count) : копіює зі списку з індексу index елементи, кількість яких дорівнює count, і вставляє їх в масив array починаючи з індексу arrayIndex

                bool Contains(T item) : повертає true, якщо елемент item є у списку

                void Clear() : видаляє всі елементи зі списку

                bool Exists(Predicate<T> match) : повертає true якщо у списку є елемент, який відповідає делегату match

                T? Find(Predicate < T > match) : повертає перший елемент, який відповідає делегату match. Якщо елемент не знайдено, повертається null

                T? FindLast(Predicate<T> match) : повертає останній елемент, який відповідає делегату match. Якщо елемент не знайдено, повертається null

                List<T> FindAll(Predicate<T> match) : повертає список елементів, які відповідають делегату match

                int IndexOf(T item) : повертає індекс першого входження елемента у списку

                int LastIndexOf(T item) : повертає індекс останнього входження елемента у списку

                List<T> GetRange(int index, int count) : повертає список елементів, кількість яких дорівнює count, починаючи з індексу index.

                void Insert(int index, T item) : вставляє елемент item до списку індексу index.Якщо такого індексу у списку немає, то генерується виняток

                void InsertRange(int index, collection) : вставляє колекцію елементів collection у поточний список, починаючи з індексу index. Якщо такого індексу у списку немає, то генерується виняток

                bool Remove(T item) : видаляє елемент item зі списку і якщо видалення пройшло успішно, то повертає true.Якщо у списку кілька однакових елементів, видаляється лише перший з них

                void RemoveAt(int index) : видалення елемента за вказаним індексом index. Якщо такого індексу в списку немає, то генерується виняток.

                void RemoveRange(int index, int count) : параметр index задає індекс, з якого треба видалити елементи, а параметр count задає кількість елементів, що видаляються.

                int RemoveAll((Predicate<T> match)) : видаляє всі елементи, які відповідають делегату match.

                void Reverse() : змінює порядок елементів

                void Reverse(int index, int count) : змінює порядок на зворотний для елементів, кількість яких дорівнює count, починаючи з індексу index
            
               void Sort() : сортування списку

            *    Sort(IComparer<T> ? comparer) : сортування списку за допомогою об'єкта comparer, який передається як параметр
            */

            //  Користував вводить 5 iмен (Список)
            //  - Вставити 3 ім'я на перше місце (Вивести на екран)
            //  - Створити новий список з 2, 3, 4 імені (Вивести на екран)
            //  - Видалити друге ім'я (Вивести на екран)
            //  - Розвернути його в зворотньому порядку (Вивести на екран)
            //  - Відсортувати список (Вивести на екран)

            // Масив (статичний) // Список (Динамічний)



            string[] names = { "sasha", "ilya" }; // Array

            List<string> namesListArray = names.ToList();

            namesListArray.Add("yes");

            List<string> namesList = new List<string> { "sasha", "ilya" };
            
            namesList.Add("yes");


            namesList.ForEach(item => Console.Write(item + " "));
            Console.WriteLine();
            namesListArray.ForEach(item => Console.Write($"{item} "));
            Console.WriteLine();

        }

    }
}
