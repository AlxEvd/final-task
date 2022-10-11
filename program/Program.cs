//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine($"сколько слов ввести? ");
int num = int.Parse(Console.ReadLine());

string[] stringIn = new string[num];
for (int i = 0; i < num; i++)
{
    stringIn[i] = Console.ReadLine();
}

string[] stringOut = new string[num];
int j = 0;

for (int i = 0; i < num; i++)
{
    if (stringIn[i].Length <= 3)
    {
        stringOut[j] = stringIn[i];
        j++;
    }
}
Console.WriteLine();
for (int i = 0; i < num; i++)
{
    Console.WriteLine(stringOut[i]);
}