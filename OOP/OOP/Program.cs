using System;

//TASK 1 IN RESEARCH CLASSES
class Person
{
    public string name;
    private int age;

    public void printInfo (int age)
    {
        this.age = age;
        Console.WriteLine($"Your Name is : {name}\nand your age is : {age}");
    }
}

class Student : Person
{
    public bool isStudent;

    public void isHeAStudent()
    {
        if (isStudent)
        {
            Console.WriteLine("You Are A Student");
        }
        else
        {
            Console.WriteLine("You Are Not A Student");
        }
    }
}


//TASK 2 IN RESEARCH CLASSES
class Car {
    private string make;
    private int year;
    private string type;
    private double price;
    private string model;
    private int palletNo;
    private string color;
    private bool engineRunning;
    public Car(string make, int year, string type, double price,string model, int palletNo, string color){
        this.make = make;
        this.year = year;
        this.type = type;
        this.price = price;
        this.model = model;
        this.palletNo = palletNo;
        this.color = color;
        this.engineRunning = false;
    }
    public void StartEngine()
    {
        if (engineRunning)
            Console.WriteLine("Engine is already running.");
        else
        {
            engineRunning = true;
            Console.WriteLine("Engine started.");
        }
    }
    public void StopEngine()
    {
        if (!engineRunning)
            Console.WriteLine("Engine is already off.");
        else
        {
            engineRunning = false;
            Console.WriteLine("Engine stopped.");
        }
    }
    public void GetInfo()
    {
        Console.WriteLine($"Make: {make}\nModel:" +
            $" {model}\nYear: {year}\nType: {type}\nColor: " +
            $"{color}\nPrice: {price}\nPallet No: {palletNo}");
    }
}

class Program
{
    static void Main()
    {
        //TASK 1 IN RESEARCH
        Console.WriteLine("TASK 1 IN RESEARCH");
        Student ahmad = new Student();
        ahmad.name = "Ahmad";
        ahmad.printInfo(22);
        ahmad.isStudent = false;
        ahmad.isHeAStudent();


        //TASK 2 IN RESEARCH
        Console.WriteLine("\n\nTASK 2 IN RESEARCH");
        Car car = new Car("Toyota", 2022, "SUV", 30000, "RAV4", 101, "White");
        car.GetInfo();
        car.StartEngine();
        car.StopEngine();
    }
}