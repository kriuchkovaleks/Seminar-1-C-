//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input number 1");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number 2");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number 3");

int number3 = Convert.ToInt32(Console.ReadLine());

int max_number = number1;

if (number1 > number2 && number1 > number3 ) 
{

    Console.Write("max number is ");
    Console.WriteLine(max_number);

}

else if (number2 > number1 && number2 > number3 )
    {
        max_number = number2;
        Console.Write("max number is ");
        Console.WriteLine(max_number);
    }
    else 
    {
        max_number = number3;
        Console.Write("max number is ");
        Console.WriteLine(max_number);
    }
