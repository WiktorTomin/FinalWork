# FinalWork
Итоговая работа.
Данная работа необходима для проверки знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик.
Проверка, что базовое знакомство с IT прошло успешно.

Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:
Показываем два массива: массив X и массив Y.
Используем метод, в котором цикл равен длине массива, с условием проверки цикла (<= 3),
если "TRUE", то элемент массива Х заносится в count элемента массива Y. 
Переменная сount увеличивается на 1 и возращается к циклу (for) в котором i увеличивается на 1.

Алгоритм решения:
Делаем перебор значений из исходного массива X.
Проверяем каждое значение из массива на соответствие условию: длина строки меньше или равна трем символам.
Если строка удовлетворяет условию, кладем значение в новый массив Y.
Повторяем пункты 2 и 3 до тех пор, пока не достигнем конца исходного массива X.
Возвращаем новый заполненый массив Y как результат.

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
