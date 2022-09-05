// Напишите программу, 
// которая задаёт массив из N элементов и выводит их на экран.
Console.Write("Введите количество элементов в масиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [n];
for (int i = 0; i < n; i++)
{
    numbers[i] = new Random().Next(0, 100);
    Console.Write(numbers[i] + " ");
}