// Написать программу, которая из имеющегося масива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] mass = { "1234", "qwe", ":-))", "-2", "yes", "hello", "Ann" };
Console.Write("Исходный массив: ");
int a = mass.Length;
for (int i = 0; i < a; i++)
{
    Console.Write(mass[i] + "\t");
}
Console.WriteLine();
Console.Write("Результат: ");

string[] mass2 = new string[a];
int i2 = 0;

for (int i = 0; i < a; i++)
{
    if (mass[i].Length <= 3 == i2 < a)
    {
        string res = mass[i];
        mass2[i2] = res;
    
        Console.Write(mass2[i2] + "\t");
    }
}

