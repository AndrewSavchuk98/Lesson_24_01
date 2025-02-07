using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Статичні методи (функції)
// - Не потрібно створювати Об'єкт класу
// - Завжди буде однаковий метод для всіх використань
// - Працює з ключовим словом static
// - Викликаються в будь яких методах


// Не Статичні методи(Звичайні) (функції)
// - Потрібно створювати Об'єкт класу
// - Завжди буде різний метод для всіх використань (в кожного об'єкта різний)
// - Викликаються тільки в звичайних методах або через створення Об'єкту


// public   // Доступний всюди
// private  // Доступний тільки в цьому ж класі
// protected  // Доступний в цьому ж класі і в класі дочірньому

class Human
{
    protected string name;
    public int age;

    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void doWork()
    {
        Console.WriteLine("Something");
    }
}

class Student : Human
{
    public Student(string name, int age) : base(name, age)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }

    public override void doWork()
    {
        Console.WriteLine("Study...");
    }

}

class Worker : Human
{
    public string job;
    public Worker(string name, int age, string job) : base(name, age)
    {
        this.job = job;
    }
}

class LazyWorker : Worker
{
    public LazyWorker(string name, int age, string job) : base(name, age, job)
    {
    }
}



namespace Lesson_24_01
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Student student = new Student("Lord", 155);

              System.Console.WriteLine($" Name: {student.Name} {student.age}");

              Worker worker = new Worker("Evil", 35, "ENginear");

              Human stud = new Student("Devil", 15);
              Human w = new Worker("1", 1,"ENginear");

              Human w1 = new LazyWorker("4", 4, "ENginear");

              //worker.doWork();

              stud.doWork();
              // student.doWork();

              
              25000000000
              25_000_000_000

              print(new Student("L", 21));
              print(new Worker("L", 21, "ENginear"));
              print(w1);
  */
              Shop shop = new Shop();

            Device d = new Laptop("Lenovo", 35_000.25f, "Plastic", "White", "512GB", "16GB", "4GB", "IPS");

            shop.addDevice(new PC("Apple", 25_000f, "Plastic", "Black", "256GB", "16GB", "4GB"));
            shop.addDevice(d);
            shop.addDevice(new Phone("Pixel", 26_000f, "Plastic", "Black", "64GB", "32px", "7 inch"));
            shop.addDevice(new Phone("Apple", 23_000f, "Plastic", "RED", "256GB", "64px", "7 inch"));
            shop.addDevice(new TV("Samsung", 25_000f, "Aluminiy", "Black", "7 inch", "IPS"));
            //shop.addDevice(new TV("IPS", , "Aluminiy", "Black", "7 inch", "IPS"));
             
            shop.showDevices();
            shop.deleteDevice(d);
            Console.WriteLine("==================");
            shop.showDevices();
            Console.WriteLine("==================");
            shop.showDevices();

        }
    }
}


class Device
{
    protected string name;
    protected float price;
    protected string material;
    protected string color;

    public Device(string name, float price, string material, string color)
    {
        this.name = name;
        this.price = price;
        this.material = material;
        this.color = color;
    }

    public virtual void display()
    {
        Console.WriteLine($"{name} {price} {material} {color}");
    }
}

class Computer : Device { 
    protected string hardware;
    protected string memory;
    protected string videoCart;

    public Computer(string name, float price, string material, string color, string hardware, string memory, string videoCart) : base(name, price, material, color)
    {
        this.hardware = hardware;
        this.memory = memory;
        this.videoCart = videoCart;
    }

    public override void display()
    {
        base.display();
        Console.WriteLine($"{hardware} {memory} {videoCart}");
    }
}

class Phone: Device
{
    protected string memory;
    protected string camera;
    protected string diagonal;

    public Phone(string name, float price, string material, string color, string memory, string camera, string diagonal) : base(name, price, material, color)
    {
        this.memory = memory;
        this.camera = camera;
        this.diagonal = diagonal;
    }
    public override void display()
    {
        base.display();
        Console.WriteLine($"{memory} {camera} {diagonal}");
    }
}

class TV : Device
{
    protected string diagonal;
    protected string type_Matrix;

    public TV(string name, float price, string material, string color ,string diagonal, string type_Matrix) : base(name, price, material, color)
    {
        this.type_Matrix = type_Matrix;
        this.diagonal = diagonal;
    }
    public override void display()
    {
        base.display();
        Console.WriteLine($"{diagonal} {type_Matrix}");
    }
}

class PC : Computer
{
    public PC(string name, float price, string material, string color, string hardware, string memory, string videoCart) : base(name, price, material, color, hardware, memory, videoCart)
    {
    }

}

class Laptop : Computer
{
    protected string type_Matrix;
    public Laptop(string name, float price, string material, string color, string hardware, string memory, string videoCart, string type_Matrix) 
        : base(name, price, material, color, hardware, memory, videoCart)
    {
       this.type_Matrix = type_Matrix;
    }

    public override void display()
    {
        base.display();
        Console.WriteLine($"{type_Matrix}");

    }
}

class Shop
{
    private List<Device> devices = new List<Device>();

   public void addDevice(Device device)
    {
        devices.Add(device);
    }

    public void showDevices()
    {
        foreach (Device device in devices)
        {
            device.display();
            Console.WriteLine("**********************************");
        }
    }

    public void deleteDevice(Device device)
    {
        if (devices.Contains(device) && devices.Count > 0)
        {
            devices.Remove(device);
        }
    }
}


// Наслідування
// Device Назва, ціна, Матеріал, колір

// Дочірні класи .. Computer (Накопичувач, Пам'ять(ОЗУ), Відеокарта), Phone (Пам'ять, Камера, діагональ), TV(Діагональ, тип_Матриці)

// Дочірні класи від Computer - Laptop (тип_матриці), PC 

// void display - виводити дані всіх класів

// Створити клас Shop (), але в ньому буде список Девайсів List<Device>
// Написати функцію, яка додає в список Девайс,
// Написати функцію, яка виводить список девайсів на екран // ******************************

// Мейн - Створити 1 Лептоп, 1 ПС, 2 Телефони, 1 телевізор
// Додати їх в список, і вивести цей список на екран

/*public LazyWorker(string name, int age) : base(name, age)
{
}*/