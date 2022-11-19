//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Write("Введите необходимое количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array1[i] = element;
}

string [] array2 = new string [array1.Length];

void FinalArray (string [] array1, string [] array2)
{
    int pos = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
        array2 [pos] = array1 [i];
        pos ++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine();
FinalArray(array1, array2);
PrintArray(array2);