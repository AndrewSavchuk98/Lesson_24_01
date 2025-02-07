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

// Створити клас Rectangle,

// Буде мати метод  double squere (int a, int b) // Рахує площадь
// Буде мати метод  print (int a, int b) виводити на екран ці значення в такому форматі 
// Сторона А = 15 см., Сторона Б = 12 см.
// Створити статичний метод draw(int a, int b)
// Буде малювати прямокутник з зірок (3, 2)
// 
//  ****
//  *  *
//  *  *
//  *  *
//  ****

// Створете метод, який приймає в собі список імен, знайти кількість імен, які починаються на Голосну літеру (5 імен в списку)



namespace Lesson_24_01
{
    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student("Kolya", 15);
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();
            Console.WriteLine($"{student1.name} {student1.age}");

            student1.name = "Petya";
            //student2.name = "Petya";
            student1.age = 18;
            //student2.age = 17;

            Console.WriteLine($"{student1.name} {student1.age}");
            Console.WriteLine("**********************");

            Console.WriteLine($"{student2.name} {student2.age}");
            Console.WriteLine($"{student3.name} {student3.age}");
            Console.WriteLine($"{student4.name} {student4.age}");
            Console.WriteLine($"{student5.name} {student5.age}");
            Console.WriteLine(student1);
            Console.WriteLine(student2.name);
            Console.WriteLine("**********************");

            Bus bus =  new Bus("Mersedes", 355, 7, "Black", "Mykola Vickorovich");
            //Bus bus = new Bus();
            bus.Number = 15;
            bus.show();

            //bus.name = "Test";
            //bus.getName();

            //bus.number = 35;

            bus.show();
            bus.addStudents(student1);
            bus.addStudents(student2);
            bus.addStudents(student3);
            bus.addStudents(student4);
            bus.addStudents(student5);
            bus.showFreeSeats();
            bus.removeStudent(student2);
            bus.showFreeSeats();


        }
    }
}

// Створити клас Bus
// Прописати властивості назва, номер автобусу, кількість місць, Колір, Водій (текстове поле), Список студентів, кількість вільних місць
// Створити 2 конструктора Один пустий, а інший з параметрами
// Створити метод Який виводить Дані Автобуса
// // Створити метод заповнення автобусу студентами в залежності від кількості місць
// // Створити метод звільнення автобусу студентами 
// Створити метод, який виводить кількість вільних місць

// 
// static 

// Class 
// public private

class Bus
{
    private string name;
    
    private int number;

    public int Number
    {
        private get { return number; }

        set { number = value + 1; }
    }

    public int totalSeats;
    public string color;
    public string driver;

    List<Student> students = new List<Student>();
    public int freeSeats;


    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public Bus()
    {

    }

    public Bus(string name, int number, int totalSeats, string color, string driver)
    {
        this.name = name;
        this.number = number;
        this.totalSeats = totalSeats;
        this.color = color;
        this.driver = driver;
        this.freeSeats = totalSeats;
    }

    public void show()
    {
        Console.WriteLine($"Bus {name} #{number} {color} color, with {totalSeats} seats, on drive {driver}");
    }

    public void addStudents(Student student)
    {
        if (freeSeats > 0)
        {
            students.Add(student);
            freeSeats--;
        }
        else
        {
            Console.WriteLine("Not more seats");
        }
    }

    public void removeStudent(Student student)
    {
        students.Remove(student);
        if (freeSeats < totalSeats)
        {
            freeSeats++;
        }
    }

    public void remStud(int id)
    {
        foreach (Student student in students)
        {
            if (student.id == id)
            {
                students.Remove(student);
            }
        }

        // [0, 1, 2, 3]
       
        // [0, 1, 3]
        // [0, 1, 2, 3]


        // i == [0]

        for (int i = 0; i < students.Count; i++)
        {   
            if(students[i].id == id)
            {
                students.RemoveAt(i);
            }
        }

    }

    public void showFreeSeats()
    {
        Console.WriteLine($"Seat left: {freeSeats}");
    }
}

class Student
{
    public int id = 0;
    public string name;
    public int age;
//    public List<Student> students;
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Student()
    {
        name = "Vasya";
        age = 12;
    }
}





// Наслідування
// 

// i0j0 i0j1 i0j2 i0j3 
// i1j0 i1j1 i1j2 i1j3
// i2j0 i2j1 i2j2 i2j3
// i3j0 i3j1 i3j2 i3j3