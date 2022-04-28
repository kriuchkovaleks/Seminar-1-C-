// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input random number");

int number = Convert.ToInt32(Console.ReadLine());

int i = 1; 

Console.WriteLine("Even numbers from 1 to number are: ");

while (i < number)
{
    if ((i % 2) == 0)
    {
        
        Console.WriteLine(i);

    }

    i = i + 1;

}
