// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input random number");

int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{

Console.WriteLine("Even number");

}

else 
{
    Console.WriteLine("Not Even number");
}


