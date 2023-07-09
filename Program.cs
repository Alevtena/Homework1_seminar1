// Напишите программу, которая на вход принимает два числа и выдаёт большее число.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write ("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) Console.WriteLine ("Max number is: " + num1);
else Console.WriteLine ("Max number is: " + num2);