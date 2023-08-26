// See https://aka.ms/new-console-template for more information

// string? test = Console.ReadLine();
// Console.WriteLine($"{test}");

while(true)
{
try
{
int sum;

 Console.WriteLine("Please enter a number: ");

 var firstNumber = int.Parse(Console.ReadLine());

 Console.WriteLine("Please enter a second number: ");
 var secondNumber = int.Parse(Console.ReadLine());

sum = firstNumber + secondNumber;
Console.WriteLine("The sum of the entered numbers is: " + sum);
break;

}
catch(Exception e)
{
    Console.WriteLine("Please try again " + e.Message);
}
}