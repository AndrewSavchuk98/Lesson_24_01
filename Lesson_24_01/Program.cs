using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_24_01
{


    class Program
    {

        // Написати функцію яка приймає в себе список чисел, і вертає середнє значення елементів списку

        // 
        static double avarageList(List<int> numbers)
        {
            double sum = 0;
            numbers.ForEach(x => sum += x);
            return sum / numbers.Count;
        }



        int sum(int a, int b)
        {
            List<int> numbers = new List<int>();
            printList(numbers);
            return a + b;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Main function");

            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(10));
            }
            printList(numbers);

            double result = avarageList(numbers);
            Console.WriteLine(result);

            Program program = new Program();

            Console.WriteLine(program.sum(5, 10));



        }

        static void printList(List<int> numbers)
        {
            numbers.ForEach(number => Console.WriteLine(number));
        }
    }
}
