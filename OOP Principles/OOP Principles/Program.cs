using System;

//TASK 1
static class MathUtilities {

    public static int square(int num)
    {
        return num * num;
    }

    public static double squareRoot(int num)
    {
        return Math.Sqrt(num);
    }

    public static int maxNum (int a , int b)
    {
        return Math.Max(a, b);
    }
}
//////////////////////////////////////////////////////////////
//TASK 2
class Converter
{
    public static double toFahrenheit(double value) 
    {
        return (value * 9 / 5) + 32;
    }

    public static double toMiles (double value)
    {
        return value * 0.621371;
    }
}
//////////////////////////////////////////////////////////////

//TASK 3
class VisitorCounter
{
    private static int visitorCount = 0;
    public VisitorCounter()
    {
        visitorCount++;
    }
    public static void DisplayCount()
    {
        Console.WriteLine("Number of visitors: " + visitorCount);
    }
}
//////////////////////////////////////////////////////////////
//TASK 4
class Company
{
    public static string CompanyName { get; set; }
    public string EmployeeName { get; set; }
    public Company(string employeeName)
    {
        EmployeeName = employeeName;
    }
    public void PrintInfo()
    {
        Console.WriteLine(EmployeeName + " works at " + CompanyName);
    }
}
//////////////////////////////////////////////////////////////
//TASK 5
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat says: Meow");
    }
}
class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
abstract class Shape
{
    public abstract double GetArea(); 
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double GetArea()
    {
        return Width * Height;
    }
}
//////////////////////////////////////////////////////////////
//TASK 6
class CalculatorOverload
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
}

//////////////////////////////////////////////////////////////
//TASK 7
class AnimalSound
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
class Dog : AnimalSound
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog says: Woof");
    }
}
class CatSound : AnimalSound
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat says: Meow");
    }
}

//////////////////////////////////////////////////////////////
//TASK 8
abstract class Appliance
{
    public string Brand { get; set; }
    public Appliance(string brand)
    {
        Brand = brand;
    }
    public abstract void TurnOn();
    public abstract void TurnOff();
}
class WashingMachine : Appliance
{
    public WashingMachine(string brand) : base(brand)
    {
    }
    public override void TurnOn()
    {
        Console.WriteLine(Brand + " washing machine: starting the wash cycle...");
    }
    public override void TurnOff()
    {
        Console.WriteLine(Brand + " washing machine: wash cycle complete, powering off.");
    }
}
class AirConditioner : Appliance
{
    public AirConditioner(string brand) : base(brand)
    {
    }
    public override void TurnOn()
    {
        Console.WriteLine(Brand + " air conditioner: cooling mode activated, temperature dropping.");
    }
    public override void TurnOff()
    {
        Console.WriteLine(Brand + " air conditioner: shutting down, fan stopping.");
    }
}

//////////////////////////////////////////////////////////////
//TASK 9
class BankAccount
{
    private decimal balance;
    public decimal Balance
    {
        get { return balance; }
    }
    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        balance += amount;
        Console.WriteLine("Deposited: " + amount + " | New balance: " + balance);
    }
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Withdrawal denied: insufficient funds. Balance: " + balance);
            return;
        }

        balance -= amount;
        Console.WriteLine("Withdrew: " + amount + " | New balance: " + balance);
    }
}

//////////////////////////////////////////////////////////////
//TASK 10
abstract class Employee
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;
    }
    public abstract decimal CalculateSalary();
}
class FullTimeEmployee : Employee
{
    public decimal MonthlySalary { get; set; }
    public FullTimeEmployee(string name, decimal monthlySalary) : base(name)
    {
        MonthlySalary = monthlySalary;
    }
    public override decimal CalculateSalary()
    {
        return MonthlySalary;
    }
}
class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }
    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}
////////////////////////////////////////////////////////////
//PROGRAM CLASS
class Program
{
    static void Main()
    {
        //TASK 1
        //Console.WriteLine(MathUtilities.square(5));
        //Console.WriteLine(MathUtilities.squareRoot(25));
        //Console.WriteLine(MathUtilities.maxNum(1,10));

        //TASK 2
        //Console.WriteLine("to Fahrenheit : " +Converter.toFahrenheit(24));
        //Console.WriteLine("to Miles : " +Converter.toMiles(10));

        //TASK 3
        //VisitorCounter v1 = new VisitorCounter();
        //VisitorCounter v2 = new VisitorCounter();
        //VisitorCounter v3 = new VisitorCounter();
        //VisitorCounter.DisplayCount();

        //TASK 4
        //Company.CompanyName = "TechCorp";
        //Company emp1 = new Company("Ahmad");
        //Company emp2 = new Company("Sara");
        //Company emp3 = new Company("Omar");
        //emp1.PrintInfo();
        //emp2.PrintInfo();
        //emp3.PrintInfo();

        //TASK 5
        //Calculator calc = new Calculator();
        //Console.WriteLine("Add(2, 3) = " + calc.Add(2, 3));
        //Console.WriteLine("Add(2.5, 3.5) = " + calc.Add(2.5, 3.5));
        //Console.WriteLine("Add(1, 2, 3) = " + calc.Add(1, 2, 3));
        //Console.WriteLine();
        //Animal myAnimal = new Animal();
        //myAnimal.Speak();
        //Animal myCat = new Cat();
        //myCat.Speak();
        //Console.WriteLine();
        //Person person = new Person();
        //person.Name = "Ahmad";
        //Console.WriteLine("Person name: " + person.Name);
        //Console.WriteLine();
        //Shape rect = new Rectangle(4, 5);
        //Console.WriteLine("Rectangle area: " + rect.GetArea());

        //TASK 6
        //CalculatorOverload calc2 = new CalculatorOverload();
        //Console.WriteLine("Add(5, 10) = " + calc2.Add(5, 10));
        //Console.WriteLine("Add(5, 10, 15) = " + calc2.Add(5, 10, 15));
        //Console.WriteLine("Add(2.5, 3.7) = " + calc2.Add(2.5, 3.7));

        //TASK 7
        //AnimalSound myDog = new Dog();
        //myDog.MakeSound();
        //AnimalSound myCat = new CatSound();
        //myCat.MakeSound();

        //TASK 8
        //Appliance washer = new WashingMachine("Samsung");
        //washer.TurnOn();
        //washer.TurnOff();
        //Console.WriteLine();
        //Appliance ac = new AirConditioner("LG");
        //ac.TurnOn();
        //ac.TurnOff();

        //TASK 9
        //BankAccount account = new BankAccount(100);
        //Console.WriteLine("Starting balance: " + account.Balance);
        //account.Deposit(50);
        //account.Withdraw(30);
        //account.Withdraw(500);
        //account.Deposit(-10);
        //Console.WriteLine("Final balance: " + account.Balance);

        //TASK 10
        Employee fullTime = new FullTimeEmployee("Ahmad", 3000);
        Console.WriteLine(fullTime.Name + " (Full-time) salary: " + fullTime.CalculateSalary());
        Employee partTime = new PartTimeEmployee("Sara", 15, 80);
        Console.WriteLine(partTime.Name + " (Part-time) salary: " + partTime.CalculateSalary());


    }
}