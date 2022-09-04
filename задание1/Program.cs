// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int number = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень числа: ");
int i = 1;
int result = number;
while (i < degree)
{
    result = result * number;
    i ++;
}
Console.Write($"{number} в степени {degree} = {result}.");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}