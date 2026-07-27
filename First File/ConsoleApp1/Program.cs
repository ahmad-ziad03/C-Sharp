using System;

class Program
{
    static void Main()
    {
        //TASK 1
        Console.WriteLine("TASK 1");
        string name = "Ahmad";
        int age = 22;
        Console.WriteLine("My Name is " + name + "and i am " + age + " years old");

        //TASK 2    
        Console.WriteLine("TASK 2");
        Console.WriteLine("ente your age");
        int numFromUser = Convert.ToInt32(Console.ReadLine());
        if (numFromUser % 2 != 0)
        {
            Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("Even");
        }

        //TASK 3
        Console.WriteLine("TASK 3");
        Console.WriteLine("Enter A String");
        Console.WriteLine(Console.ReadLine());

        //TASK 4
        Console.WriteLine("TASK 4");
        int number = -2;
        if (number < 0)
        {
            Console.WriteLine("Negative");
        }
        else if (number > 0)
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Zero");
        }

        //TASK 5    
        Console.WriteLine("TASK 5");
        int numberOfDays = 365;
        if (numberOfDays == 366)
        {
            Console.WriteLine("A Leap Year");
        }
        else
        {
            Console.WriteLine("Normal Year");
        }

        //TASK 6    
        Console.WriteLine("TASK 6");
        double grade = 51;
        if (grade > 50)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }

        //Task 7
        Console.WriteLine("TASK 7");
        int firstNum = 150;
        int secondNum = 20;
        if (firstNum > secondNum)
        {
            Console.WriteLine($"{firstNum} is bigger than {secondNum}");
        }
        else
        {
            Console.WriteLine($"{secondNum} is bigger than {firstNum}");
        }

        //TASK 8
        Console.WriteLine("TASK 8");
        int checkOn5And3 = 15;
        if (checkOn5And3 % 5 == 0 && checkOn5And3 % 3 == 0)
        {
            Console.WriteLine($"The Number {checkOn5And3} is divisible by 5 and 3");
        }
        else
        {
            Console.WriteLine($"The Number {checkOn5And3} is not divisible by 5 and 3");
        }

        //TASK 9
        Console.WriteLine("TASK 9");
        char letter = 'h';
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine($"Letter {letter} is a Vowel");
        }
        else
        {
            Console.WriteLine($"Letter {letter} is not a Vowel");
        }

        //TASK 10   
        Console.WriteLine("TASK 10");
        Console.WriteLine("enter your age");
        int enteredAge = Convert.ToInt32(Console.ReadLine());
        if (enteredAge <= 15)
        {
            Console.WriteLine("You are a child");
        }
        else if (enteredAge > 15 && enteredAge <= 18)
        {
            Console.WriteLine("You are a teenager");
        }
        else
        {
            Console.WriteLine("you are an adult");
        }

        //TASK 11
        Console.WriteLine("TASK 11");
        int numDay = 1;
        switch (numDay)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
        }

        //Task 12
        Console.WriteLine("TASK 12");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
        }

        //TASK 13
        Console.WriteLine("TASK 13");
        double num1, num2;
        char operation;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;
            }

            //TASK 14   
            Console.WriteLine("TASK 14");
        char grade2 = 'A';
        switch (grade2)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("Very Good");
                break;
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'D':
                Console.WriteLine("Pass");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
        }

        //TASK 15   
        Console.WriteLine("TASK 15");
        int number2 = 2;
        switch (number2)
        {
            case 1:
                Console.WriteLine("You selected option 1");
                break;
            case 2:
                Console.WriteLine("You selected option 2");
                break;
            case 3:
                Console.WriteLine("You selected option 3");
                break;
        }

        //TASK 16
        Console.WriteLine("TASK 16");
        int checkEvenOdd = 9;
        switch (checkEvenOdd % 2 == 0)
        {
            case true:
                Console.WriteLine("Even Number");
                break;
            case false:
                Console.WriteLine("Odd Number");
                break;
        }

        //TASK 17
        Console.WriteLine("TASK 17");
        Console.WriteLine("Enter Your Role");
        string role = Console.ReadLine();

        switch (role)
        {
            case "Admin":
                Console.WriteLine("Welcome, Admin");
                break;
            case "User":
                Console.WriteLine("Welcome, User");
                break;
            case "Guest":
                Console.WriteLine("Welcome, Guest");
                break;
            default:
                Console.WriteLine("Invalid role!");
                break;
        }

        //TASK 18   
        Console.WriteLine("TASK 18");
        Console.WriteLine("===== Menu =====");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Show Date");
        Console.WriteLine("3. Exit");

        int menuChoice = Convert.ToInt32(Console.ReadLine());

        switch (menuChoice)
        {
            case 1:
                Console.WriteLine("Hello!");
                break;
            case 2:
                Console.WriteLine(DateTime.Now);
                break;
            case 3:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }


        //TASK 19
        Console.WriteLine("TASK 1 Advanced if");
        double rating;

        Console.Write("Enter employee rating: ");
        rating = Convert.ToDouble(Console.ReadLine());

        if (rating >= 90 && rating <= 100)
        {
            Console.WriteLine("Performance: Excellent");
            Console.WriteLine("Bonus: 20%");
        }
        else if (rating >= 75 && rating < 90)
        {
            Console.WriteLine("Performance: Very Good");
            Console.WriteLine("Bonus: 15%");
        }
        else if (rating >= 60 && rating < 75)
        {
            Console.WriteLine("Performance: Good");
            Console.WriteLine("Bonus: 10%");
        }
        else if (rating < 60 && rating >= 0)
        {
            Console.WriteLine("Performance: Below Expectations");
            Console.WriteLine("Bonus: No bonus");
        }
        else
        {
            Console.WriteLine("Invalid rating!");
        }

        //TASK 20
        Console.WriteLine("TASK 2 Advanced if");
        double gpa;
        bool passedEnglish;
        bool hasRecommendation;

        Console.Write("Enter GPA: ");
        gpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Has passed English test? (true/false): ");
        passedEnglish = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Has special recommendation? (true/false): ");
        hasRecommendation = Convert.ToBoolean(Console.ReadLine());

        if ((gpa >= 85 && passedEnglish) || hasRecommendation)
        {
            Console.WriteLine("Student is eligible for admission");
        }
        else
        {
            Console.WriteLine("Student is not eligible for admission");
        }

        //TASK 21
        Console.WriteLine("TASK 3 Advanced if");
        double weight;

        Console.Write("Enter package weight (kg): ");
        weight = Convert.ToDouble(Console.ReadLine());

        if (weight <= 1)
        {
            Console.WriteLine("Delivery cost: $5");
        }
        else if (weight > 1 && weight <= 5)
        {
            Console.WriteLine("Delivery cost: $10");
        }
        else if (weight > 5 && weight <= 10)
        {
            Console.WriteLine("Delivery cost: $20");
        }
        else if (weight > 10)
        {
            Console.WriteLine("Delivery cost: $50");
            Console.WriteLine("Warning: Heavy package");
        }
        else
        {
            Console.WriteLine("Invalid weight!");
        }

        //TASK 22
        Console.WriteLine("TASK 4 Advanced if");
        string username, password;
        int failedAttempts = 4;

        Console.Write("Enter username: ");
        username = Console.ReadLine();

        Console.Write("Enter password: ");
        password = Console.ReadLine();

        if (failedAttempts > 3)
        {
            Console.WriteLine("Account locked");
        }
        else if (username == "admin" && password == "1234")
        {
            Console.WriteLine("Login successful");
        }
        else
        {
            Console.WriteLine("Invalid credentials");
        }

        //TASK 23
        Console.WriteLine("TASK 1 Advanced switch");
        int foodChoice = Convert.ToInt32(Console.ReadLine());
        switch (foodChoice)
        {
            case 1:
                Console.WriteLine("Burger - $5");
                break;
            case 2:
                Console.WriteLine("Pizza - $8");
                break;
            case 3:
                Console.WriteLine("Pasta - $7");
                break;
            case 4:
                Console.WriteLine("Salad - $4");
                break;
        }

        //TASK 24
        Console.WriteLine("TASK 2 Advanced switch");
        Console.WriteLine("Enter A Number To Check if it is even or odd");
        int checkEvenOdd2 = Convert.ToInt32(Console.ReadLine());
        switch (checkEvenOdd2 % 2 == 0)
        {
            case true:
                Console.WriteLine("Even Number");
                break;
            case false:
                Console.WriteLine("Odd Number");
                break;
        }

        //TASK 25
        Console.WriteLine("TASK 3 Advanced switch");
        Console.WriteLine("enter a number for a service");
        Console.WriteLine("1 → Check Balance");
        Console.WriteLine("2 → Deposit Money");
        Console.WriteLine("3 → Withdraw Money");
        Console.WriteLine("4 → Exit");
        int atmChoice = Convert.ToInt32(Console.ReadLine());
        switch (atmChoice)
        {
            case 1:
                Console.WriteLine("Checking balance...");
                break;
            case 2:
                Console.WriteLine("Depositing money...");
                break;
            case 3:
                Console.WriteLine("Withdrawing money...");
                break;
            case 4:
                Console.WriteLine("Exiting ATM...");
                break;
        }

        //TASK 25
        Console.WriteLine("TASK 3 Advanced switch");
        double calcNum1, calcNum2;
        int calcChoice;
        Console.Write("Enter first number: ");
        calcNum1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        calcNum2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("1 → Addition");
        Console.WriteLine("2 → Subtraction");
        Console.WriteLine("3 → Multiplication");
        Console.WriteLine("4 → Division");
        Console.Write("Choose operation: ");
        calcChoice = Convert.ToInt32(Console.ReadLine());
        switch (calcChoice)
        {
            case 1:Console.WriteLine("Result: " + (calcNum1 + calcNum2));
                break;
            case 2:Console.WriteLine("Result: " + (calcNum1 - calcNum2));
                break;
            case 3:Console.WriteLine("Result: " + (calcNum1 * calcNum2));
                break;
            case 4:
                if (calcNum2 != 0)
                    Console.WriteLine("Result: " + (calcNum1 / calcNum2));
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

}