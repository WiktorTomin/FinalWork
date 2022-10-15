// Написать программу. которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символам. Первоначальный массив можно ввести 
// непосредственно  с клавиатуры, либо задать на старте выполнения алгоритма.

string[] arrayX = new string[] {"hello", "2", "world", ":)"};
string[] arrayY = new string[arrayX.Length];
void GetArray(string[] arrayX, string[] arrayY)
{
    int count = 0;
    for (int i = 0; i < arrayX.Length; i++)
    {
    if(arrayX[i].Length <= 3)
        {
        arrayY[count] = arrayX[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetArray(arrayX, arrayY);
PrintArray(arrayY);








