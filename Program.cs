// Задача 34. Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.
void zadacha34()
{
Console.WriteLine("Введите число, равное количеству элементов в массиве:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего в нашем массиве {numbers.Length} чисел, а {count} из них чётные числа");




void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}}


// Задача 36.Задайте одномерный массив,
// заполненный случайными числами. 
// Найдите сумму элементов с
// нечётными индексами.
void Zadacha36()

{
    Console.WriteLine("Введите число, равное количеству элементов в массиве:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 !=0)
count++;

Console.WriteLine($"всего в нашем массиве {numbers.Length} чисел, а {count} из них относится к нечётным");

sum = 0;
for (int b=0;b<numbers.Length;b++)
{
    if(numbers[b]%2==0) count++;
    if (b % 2==1) sum += numbers[b];
}
Console.WriteLine("Сумма нечетных элементов с нечётными индексами:"+ sum);


void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-1,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
}

// Задача 38.Задайте массив вещественных чисел.
// Найдите разницу между 
// максимальным и минимальным
// элементов массива.
void Zadacha38()
{

    Random rnd = new Random();
            int[] d = new int[30];
            int max=0, min=100;
            for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }
           
               for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
               Console.WriteLine();
                 Console.WriteLine("max:  " + max);
                 Console.WriteLine("min  " +min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                Console.ReadKey();
}
// zadacha34();
// Zadacha36();
// Zadacha38();
