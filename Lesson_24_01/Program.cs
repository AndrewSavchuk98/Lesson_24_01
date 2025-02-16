using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

// Структури (об'єкти)
// Комп'ютер (Назва, Марка, Пам'ять, Колір, Ціна)

/*struct Computer
{
    public string name;

    public string mark;

    public int memory;

    public string color;

    public float price;

    private int ID;

    public int id
    {
        get { return ID + Convert.ToInt32(price); }
        set { 
            if (value == 12)
            {
                price = 0;
            }
            ID = value; 
        }
    }

    public Computer(string name, string mark, int memory, string color, float price, int id)
    {
        this.name = name;
        this.mark = mark;
        this.memory = memory;
        this.color = color;
        this.price = price;
        this.ID = id;
    }

    public void print()
    {
        Console.WriteLine("***************************");
        Console.WriteLine(name);
        Console.WriteLine(mark);
        Console.WriteLine(memory);
        Console.WriteLine(color);
        Console.WriteLine(price);
        Console.WriteLine($"ID: {id}");
        Console.WriteLine("***************************");
    }
}

struct Product
{
    public string name;
    public float price;
    public int quantity;
    public Days day;

    public Product(string name, float price, int quantity)
    {
        this.name   = name;
        this.price = price;
        this.quantity = quantity;
    }


    public void print()
    {
        Console.WriteLine("***************************");
        Console.WriteLine(name);
        Console.WriteLine(price);
        Console.WriteLine(quantity);
        Console.WriteLine("***************************");
    }

    public float getTotalPrice()
    {
        return price * quantity;
    }

}
*/
// List<Product> products = new List<Product>() {product1, product2};

// Створити структуру Продакт, яка собі містить (Назва, Ціна, Кількість на складі)
// Створити кілька продуктів,
// Написати функцію, яка виводить інформацію про продукт,
// Написати функцію, яка розраховує загальну вартість товару Ціна * Кількість на складі (Повертає цей результат)
// Створити список Цих продуктів, і порахувати загальну вартість всіх товарів

class Test
{

    public int? t;
    public void print()
    {
        Console.WriteLine("hello");
    }
}

// Nullable - Нульові поля

// enum - перелічування

//
enum Days
{
    Monday = 1, // 0    // 1
    Tuesday, // 1       // 2
    Wednesday, // 2     // 3
    Thursday, // 3      // 4
    Friday,  // 4       // 5
    Saturday, // 5      // 6
    Sunday  // 6        // 7
}

enum SeatStatus
{
    Free,
    Reserved,
    Sold
}
struct Seat
{
    public int raw;
    public int number;
    public SeatStatus status;

    public Seat (int raw, int number, SeatStatus status)
    {
        this.raw = raw;
        this.number = number;
        this.status = status;
    }
}


// Створити enum для статусу місця (Вільне, Зарезервоване, Продане)
// Створити Структуру Місце яке містить в собі поля (Рядок, Номер місця і Статус (enum))
// Створити список місць у залі (Main) (6 штук)
// Випідковим значенням призначаєте всі місця Різними рандомними значеннями статусів 
//Random random = new Random();
//random.Next(2);
/*
if (random == 0) {
    seat.status = SeatStatus.Free;
}*/

// Користувач вводить Ряд і місце, і перевіряти якщо це місце доступне то виводи Повідомлення Успiшно зарезервоване (Зарезервоване)
// Нажаль зарезервоване
// Нажаль продане


namespace Lesson_24_01
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Random random = new Random();

            List<Seat> seats = new List<Seat> ();

            for (int i = 0; i < 6; i++)
            {

                SeatStatus status = SeatStatus.Free;

                int res = random.Next (2 + 1);
                switch(res)
                {
                    case 0: status = SeatStatus.Free; break;
                    case 1: status = SeatStatus.Reserved; break;
                    case 2: status = SeatStatus.Sold; break;
                    default: status = SeatStatus.Free; break;
                }
                int raw = 1;
                raw++;
                if (i % 3 == 0)
                {
                    raw = 1;
                }

                Seat seat = new Seat(raw, i, status);
                seats.Add(seat);

            }

            foreach (Seat seat in seats)
            {
                Console.WriteLine($"RAW: {seat.raw}");
                Console.WriteLine($"NUMBER: {seat.number}");
                Console.WriteLine($"STATUS: {seat.status}");
            }

            Console.WriteLine("Intput Raw ");
            int inputRaw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Intput Number ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < seats.Count(); i++)
            {
                if (seats[i].number == inputNumber && seats[i].raw == inputRaw)
                {
                    switch (seats[i].status)
                    {
                        case SeatStatus.Free:  Console.WriteLine("Успiшно зарезервоване");
                            {
                                Seat seat = seats[i];
                                seat.status = SeatStatus.Reserved;
                                seats[i] = seat;
                                break;
                            }
                        case SeatStatus.Reserved:  Console.WriteLine("Вже зарезервоване"); break;
                        case SeatStatus.Sold:  Console.WriteLine("Продано"); break;
                    }
                }
            }

            foreach (Seat seat in seats)
            {
                Console.WriteLine($"RAW: {seat.raw}");
                Console.WriteLine($"NUMBER: {seat.number}");
                Console.WriteLine($"STATUS: {seat.status}");
            }

            /*  Days today = Days.Sunday;

              Console.WriteLine((int)today);

              Console.WriteLine("Enter number ");
              int test = Convert.ToInt32(Console.ReadLine());
              switch (test)
              {
                  case (int)Days.Monday: Console.WriteLine("Hello from Monday"); break;
                  case (int)Days.Tuesday: Console.WriteLine("Hello from Tuesday"); break;
                  case (int)Days.Wednesday: Console.WriteLine("Hello from Wednesday"); break;
                  case (int)Days.Thursday: Console.WriteLine("Hello from Thursday"); break;
                  case (int)Days.Friday: Console.WriteLine("Hello from Friday"); break;
                  case (int)Days.Saturday: Console.WriteLine("Hello from Saturday"); break;
                  case (int)Days.Sunday: Console.WriteLine("Hello from Sunday"); break;

              }*/


            /*

                        Test test = new Test();

                        test.print();

                        test = null;

                        if (test == null)
                        {
                            test = new Test();
                        }

                        test.t = null;

                        test.print();


                        int? number = 0;
                        number = null;



                        Console.WriteLine(number);*/




        }
    }
}
