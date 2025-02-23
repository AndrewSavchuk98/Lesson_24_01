using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Threading;
// аргументи за посиланням i за копіями

// Абстракція (Абстрактні класи)

// 1 - Не можна створювати екземрляри класу ( Animal a = new Animal();   - НЕ МОЖНА)
// 2 - є Абстрактні методи (це метод без реалізації, який мають реалізувати класи наслідники)
// 3 - Можуть містити в собі реалізовані методи
// 4 - Можуть містити поля, властивості та коструктори
// 5 - Всі наслідники обов'язково мають реалізувати всі абстрактні методи
// 6 - клас може наслідувати тільки один абстрактний клас


// Створити абстрактний клас Machine, який містить:
// - поле Потужність (рівень потужності) (протектед) (передавати в коструктор)
// - Абстрактний медот Operate()
// - Звичайний віртуальний метод ShowPower(), який виводить потужність

// Створити класи
// WeldingRobot (зварює деталі)
// Operate() - Повинно виводити текст, що він варить постійно і кожні пів секунди зменшувати потужність на 5 
//
//using System.Threading;

//Використовуйте Thread.Sleep(500); - для затримки на пів секунди і коли потужність 0 то зупиняємо цикл, і пишемо роботу закінчено

// PaintingRobot (фарбує деталі)
// Operate() - Повинно виводити текст, що він Малює постійно і кожну секунду зменшувати потужність на 10 
//
//using System.Threading;

//Використовуйте Thread.Sleep(1000); - для затримки на пів секунди і коли потужність 0 то зупиняємо цикл, і пишемо роботу закінчено

// Інтерфейс  (контракт, який визначає які методи повинен реалізувати клас)

// 1 - не містить реалізацію методів

// 2 - не має конструктора (бо це не клас)
// 3 - усі методи інтерфейса за замовчуваням публічні
// 4 - клас може реалізовувати кілька інтерфейсів одночасно

//


// 2 інтерфейси ReadDoc, WriteDoc
// (read)
// (write)

// class  Document //  наслідувати 2 інтерфейси (імплементувати)
// Виводи в консоль "Записано", "Прочитано"

interface ReadDoc
{
    string Read();
}


interface WriteDoc
{
    void Write(string content);
}


class SimpleDocumentManager : ReadDoc, WriteDoc
{

    private string filename;

    public SimpleDocumentManager(string filename)
    {
        this.filename = filename;
    }

    public string Read()
    {
        if (File.Exists(filename))
        {
            return File.ReadAllText(filename);
        }

        return null;
    }

    public void Write(string content)
    {
        string newText = "";
        foreach(char c in content)
        {
            newText += c.ToString().ToUpper();
        }
        Console.WriteLine(newText);

        File.WriteAllText(filename, newText);
    }
}


class JsonDocumentManager : ReadDoc, WriteDoc
{

    private string filename;
    SimpleDocumentManager manager;

    public JsonDocumentManager(string filename)
    {
        this.filename = filename;
        manager = new SimpleDocumentManager(filename);
    }

    public string Read()
    {
       return manager.Read();
    }

    public void Write(string content)
    {
        // Реалізація json
        manager.Write(content); 
    }
}


// Платіжна система 

// Створити інтерфейс  Payment з методом bool processPayment(float amount);

// Створити класи
// BankTransfer : Payment
// PayPal
// CryptoPayment

// Унаслідувати інтерфейс Payment // І в кожній реалізації виводити на екран повідомлення, операція успішна і сума і вертати тру
// 
//


// Створити клас Гаманець  з полями Person, totalAmount
// Створити клас Людина з полями name, age

// Передавати в конструктор Гаманець та в кожні реалізіції перевірити чи є гроші в гаманці, і якщо сума більша за залишок, то виводити недостатньо коштів, та Фалсе
// якщо грошей більше то віднімати суму з гаманця

// BankTransfer
// PayPal
// CryptoPayment


// Створити enum Currency (USD, UAH)
// Додати до інтерфесу Payment метод float convert (float amount, Currency from, Currency to)
// Реалізувати ці методи

// Фомули
// Для UAH -> USD / 42
// Для USD -> UAH * 42


// Але для кожного класу треба реалізувати комісію конвертації 

// Для 
// BankTransfer   комісія 2%
// PayPal     комісія 5%
// CryptoPayment  комісія 3%

// Створити інтерфейс Log з методом write(string data)
// Який записує дані з методу processPayment в файл (додаючі до кінця через кому)
// Реалізувати цей інтерфейс для класу SimpleLog та в кожному з трьох класів створити цей об'єкт та записати дані з виклику processPayment

interface Log
{
    void write(string data);
}

class SimpleLog : Log
{
    public void write(string data)
    {
        File.AppendAllText("logs.txt", data + ", ");
    }
}

enum Currency
{
    USD,
    UAH
}

interface Payment
{
    bool processPayment(float amount);

    float convert(float amount, Currency from, Currency to);
}

class Person
{
    public string name;
    public int age;
}

class Wallet
{
    public float totalAmount;
    public Person person;
}




class BankTransfer : Payment
{
    private Log log;
    private Wallet Wallet;
    public BankTransfer(Wallet wallet)
    {
        this.Wallet = wallet;
        log = new SimpleLog();
    }

    public float convert(float amount, Currency from, Currency to)
    {
        if (from == Currency.USD)
        {
            return amount * 42 * 0.02f;
        }

        if (from == Currency.UAH)
        {
            return amount / 42 * 0.02f;
        }

        return 0f;
    }
    // Створити інтерфейс Log з методом write(string data)
    // Який записує дані з методу processPayment в файл (додаючі до кінця через кому)
    // Реалізувати цей інтерфейс для класу SimpleLog та в кожному з трьох класів створити цей об'єкт та записати дані з виклику processPayment

    public bool processPayment(float amount)
    {
        string message;

        bool result = false;
        if (Wallet.totalAmount >= amount)
        {
            message = $"Операція успішна {amount}";
            
            Wallet.totalAmount -= amount;
            result = true;
        }
        else
        {
            message = $"Недостатньо коштів {amount}";
        }
        Console.WriteLine(message);
        log.write(message);
        return result;
    }
}




///"C:\Users\student\Desktop\simleFile.txt"


namespace Lesson_24_01
{
    internal class Program
    {

        static string fileName = "C:\\Users\\student\\Desktop\\simleFile.txt";
        static JsonDocumentManager m = new JsonDocumentManager(fileName);
     
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text ");
            string result = Console.ReadLine();

            SimpleDocumentManager manager = new SimpleDocumentManager(fileName);
            manager.Write(result);


            Console.WriteLine(m.Read());

            test();
            readTest();


        }


        static void test()
        {

            m.Write("Test");

        }

        static void readTest()
        {
            m.Read();
        }

    }
}
