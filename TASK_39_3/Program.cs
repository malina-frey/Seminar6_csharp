/*
Задача 39: Напишите программу, 
которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] GenersteArray(int size, int loweBorder, int upperBorder)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(loweBorder, upperBorder + 1);
    }
    return result;
}

void PrintArray(int[] arrayToPrint, string name = "")
{
    Console.ForegroundColor=ConsoleColor.Green;
    if (string.IsNullOrEmpty(name))
    {

    }
    Console.WriteLine($"Массив {name}");
    Console.WriteLine("----------------------------------------------------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("----------------------------------------------------------------------");
    Console.WriteLine();
}

int[] ReversArray(int[] arrayToRevers)
{
    int[] result = new int[arrayToRevers.Length];
    for (int i = 0; i < arrayToRevers.Length; i++)
    {
        result[i] = arrayToRevers[arrayToRevers.Length - 1 - i];
    }
    return result;
}
Console.Clear();
int[] arrayToReverse = GenersteArray(5, -10, 10);
PrintArray(arrayToReverse, "Тундра");
int[] reversedArray = ReversArray(arrayToReverse);
PrintArray(reversedArray, "Сюндра");