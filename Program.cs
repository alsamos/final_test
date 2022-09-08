// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

string[] CreateArray(int size)
{
    string[] newArray = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}й элемент массива, строку:  ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void LessOrEqualTo3Array(string[] array)
{
    Console.Write("Массив из строк, длина которых >0 и <=3 символа:  ");
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length >0 && array[i].Length <= 3) Console.Write($"{array[i]}; ");
            Console.Write("]");
            Console.WriteLine();
}

void ShowArray(string[] array)
{
    Console.Write("Полученный массив строк:  ");
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}; ");  
        Console.Write("]");
        Console.WriteLine();
}



Console.Write("Введите количество элементов массива строк:  ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(size);
ShowArray(array);
LessOrEqualTo3Array(array);

