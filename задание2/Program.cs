// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0;

while (number > 0)
{
    a += number % 10;
    number/= 10;
}
Console.Write($"Cумма цифр введённого Вами числа равна {a}.");
