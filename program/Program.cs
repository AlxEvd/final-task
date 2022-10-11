//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine ($"сколько слов необходимо ввести? ");
int num = int.Parse(Console.ReadLine());

string [] array = new string [num];

for (int i = 0; i < num; i++)
{
    Console.WriteLine ($"введите {i} слово ");
    array[i] = int.Parse(Console.ReadLine());
}

int positive = 0;

foreach (int item in array)
{
    if (item >= 0)
    {
      positive ++;
    }
    
}
Console.WriteLine ($"положительных чисел {positive}");