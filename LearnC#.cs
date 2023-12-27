using System;
using System.Globalization;

Console.WriteLine("LearnC#.cs");

// Variables
int i = 1;
double d = 1.0;
string s = "s";
char c = 'c';
bool b = true;
Console.WriteLine(i + " " + d + " " + s + " " + c + " " + b);

// User Input
Console.WriteLine("Enter num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine("num1: " + num1 + ", num2: " + num2 + ", sum: " + sum);

// Math
Console.WriteLine("Math.Max(num1, num2) = " + Math.Max(num1, num2));
Console.WriteLine("Math.Min(num1, num2) = " + Math.Min(num1, num2));
Console.WriteLine("Math.Sqrt(64) = " + Math.Sqrt(64));
Console.WriteLine("Math.Abs(-5) = " + Math.Abs(-5));
Console.WriteLine("Math.Round(2.9999) = " + Math.Round(2.9999));

// Strings
Console.WriteLine("s.Length = " + s.Length);
Console.WriteLine("s.ToUpper() = " + s.ToUpper());
Console.WriteLine("s.ToLower() = " + s.ToLower());

// If else
if (num1 > num2)
    Console.WriteLine("num1 > num2");
else if (num1 < num2)
    Console.WriteLine("num1 < num2");
else if (num1 == num2)
    Console.WriteLine("num1 = num2");
else
    Console.WriteLine("ERROR");

// Switch
Random random = new Random();
int randomDay = random.Next(1, 8);
switch (randomDay){
    case 1:
        Console.WriteLine("Monday - " + randomDay);
        break;
    case 2:
        Console.WriteLine("Tuesday - " + randomDay);
        break;
    case 3:
        Console.WriteLine("Wednesday - " + randomDay);
        break;
    case 4:
        Console.WriteLine("Thursday - " + randomDay);
        break;
    case 5:
        Console.WriteLine("Friday - " + randomDay);
        break;
    case 6:
        Console.WriteLine("Saturday - " + randomDay);
        break;
    case 7:
        Console.WriteLine("Sunday - " + randomDay);
        break;
    default:
        Console.WriteLine("Unknown Day");
        break;
}

// While loop
int x = 0;
while(x < 5)
{
    Console.WriteLine(x + " ");
    x++;
}

// Do while loop
x = 0;
do
{
    Console.WriteLine(x + " ");
    x++;
} while(x < 5);

// For loop
for(int f = 0; f < 5; f++)
{
    Console.WriteLine(f + " ");
}

// Arrays
string[] fruits = { "apple", "orange", "strawberry", "banana", "blueberry" };
Console.WriteLine(fruits[0]);
foreach(string f in fruits)
    Console.WriteLine(f);

// Methods
string fullName(string firstName, string lastName)
{
    return firstName + " " + lastName;
}
Console.WriteLine(fullName("Om", "Janamanchi"));

// Classes
class Car
{
    int numWheels;
    string color;
    bool electric;

    public Car(int numWheels, string color, bool electric)
    {
        this.numWheels = numWheels;
        this.color = color;
        this.electric = electric;
    }

    public void setNumWheels(int w)
    {
        numWheels = w;
    }
    public void setColor(string c) 
    { 
        color = c;
    }

    public void setElectric(bool e)
    {
        electric = e;
    }

    public int getNumWheels() 
    { 
        return numWheels;
    }

    public string getColor() 
    {
        return color;
    }

    public bool getElectric()
    {
        return electric;
    }
}