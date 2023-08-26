// See https://aka.ms/new-console-template for more information

// string? test = Console.ReadLine();
// Console.WriteLine($"{test}");

using System.Linq.Expressions;

Console.WriteLine("Please enter an number: ");
int usernumber = int.Parse(Console.ReadLine());
//make sum a double because you can't add a int and a double xD
double sum = 0;


for (int i = 0; i < usernumber; i++)
{
    
    var numbers = double.Parse(Console.ReadLine());
    sum += numbers;
}

Console.WriteLine("The sum of the entered numbers is: " + sum);