/*
Задача 39: Напишите программу, 
которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(0, 10);
    }
}
void ReversArray(int[] array2, int[] array3)
{
    for (int i = 0; i < array3.Length; i++)
    {
        array2[i] = array3[array3.Length-1 - i];
    }
}
void PrintArray(int[] array4)
{
    Console.Write("[");
    for (int i = 0; i < array4.Length; i++)
    {
        Console.Write(array4[i]);
        if (i != array4.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] array = new int[5];
int[] result = new int[5];

FillArray(array);
ReversArray(result,array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(result);