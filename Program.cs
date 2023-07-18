/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
int Rank(int number)
{   
    int numberX = number;
    int rankNumber = 1;
    while (numberX > 9)
    {
        numberX = numberX / 10;
        rankNumber *= 10;
    }
    return rankNumber;
}

void PolyDigit(int number)
{
    int rankNumber = Rank(number);
    int numberX = 0;
    int ten = 10;
        for (int i = 1; i <= rankNumber; i = i * 10)
    {
        numberX = numberX + ((number%ten)/(ten/10)*(rankNumber/i));
        ten *= 10;
    }
    if (numberX == number)
    Console.WriteLine($"Mirror number: {numberX} - is palindrome");
    else
    Console.WriteLine($"Mirror number: {numberX} - is NOT palindrome");
}

Console.Write("Enter 2-digit number minimum: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number < 10)
{
    Console.Write("Number less then 2-digit!");
}
else PolyDigit(user_number);
*/


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double LineLengthAB(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lengthAB = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    return lengthAB;
}

Console.Write("Enter X coord A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y coord A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z coord A: ");
int zAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter X coord B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y coord B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z coord B: ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double dist = LineLengthAB(xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine($"Distence AB is {dist:f2}");
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


void PrintCube(double number)
{
    for (double temp = 1; temp <= number; temp++)
    {
        double num = Math.Pow(temp, 3);
        Console.Write(num + " ");
    }
}

Console.Write("Input your number: ");
double num = Convert.ToInt32(Console.ReadLine());

PrintCube(num);

