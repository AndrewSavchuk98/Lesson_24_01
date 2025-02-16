using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

// Структури (об'єкти)
// Комп'ютер (Назва, Марка, Пам'ять, Колір, Ціна)

struct Computer
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

// List<Product> products = new List<Product>() {product1, product2};

// Створити структуру Продакт, яка собі містить (Назва, Ціна, Кількість на складі)
// Створити кілька продуктів,
// Написати функцію, яка виводить інформацію про продукт,
// Написати функцію, яка розраховує загальну вартість товару Ціна * Кількість на складі (Повертає цей результат)
// Створити список Цих продуктів, і порахувати загальну вартість всіх товарів



namespace Lesson_24_01
{
    internal class Program
    {

        static void printComputer(Computer computer)
        {
            Console.WriteLine("***************************");
            Console.WriteLine(computer.name);
            Console.WriteLine(computer.mark);
            Console.WriteLine(computer.memory);
            Console.WriteLine(computer.color);
            Console.WriteLine(computer.price);
            Console.WriteLine("***************************");
        }

        static void Main(string[] args)
        {
            
            Computer computer = new Computer("Apple", "Pro", 256, "Black", 10_000f, 1);

            computer.print();
            computer.id = 12;
            computer.print();

            Console.WriteLine($"GET: {computer.id}");
            Console.WriteLine();

            //printComputer(computer);


            Product product = new Product("Apple", 35f, 35);
            Product product2 = new Product("Banana", 45f, 5);
            Product product3 = new Product("Cherry", 25.55f, 15);

            List<Product> products = new List<Product>() { product, product2, product3 };
           
            float totalSum = 0;

            foreach (Product p in products)
            {
                totalSum += p.getTotalPrice();
            }

            Console.WriteLine($"Total: {totalSum}");
        }
    }
}
