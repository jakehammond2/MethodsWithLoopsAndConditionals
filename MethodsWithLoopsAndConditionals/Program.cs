void Numbers()
{

    for (int i = -1000; i <= (1000); i++)
    {
        Console.WriteLine(i);
    }
}

Numbers();




void Numbers3()
{
    for (int i = 3; i <= 999; i += 3)
    {
        Console.WriteLine(i);
    }
}

Numbers3();




void AreEqual(int num1, int num2)
{
    while (num1 == num2)
    {
        Console.WriteLine($"{num1} and {num2} are equal.");
        break;
    }

    while (num1 != num2)
    {
        Console.WriteLine($"{num1} and {num2} aren't equal.");
        break;
    }
}

AreEqual(3, 2);



void EvenOdd(int x)
{
    if (x % 2 == 0)
    {
        Console.WriteLine($"{x} is even.");
    }

    else
        Console.WriteLine($"{x} is odd");
}

EvenOdd(31);



void PositiveOrNegative(int a)
{
    if (a > 0)
    {
        Console.WriteLine($"{a} is positive");
    }
    else
        Console.WriteLine($"{a} is negative");
}

PositiveOrNegative(-11);



void CanYouVote(int age)
{
    if (age >= 18)
    {
        Console.WriteLine("You can vote");
    }
    else
        Console.WriteLine("You are too young to vote");
}

CanYouVote(17);


//HEATING UP SECTION//






void RangeChecking()
{
    Console.WriteLine("What is your number?");
    int c = Convert.ToInt32(Console.ReadLine());


    if (c <= 10 && c >= -10)
    {

        Console.WriteLine("Your number is the in the range");
    }

    else
        Console.WriteLine("Your number did not fall into the range");
}


void MultiplicationTable(int number)
{
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($"{i} * {number} = {i * number}");
    }
}

MultiplicationTable(8);



