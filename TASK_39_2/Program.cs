double[] GenersteArray(int size, int loweBorder, int upperBorder)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*upperBorder+loweBorder;
    }
    return result;
}

void PrintArray(double[] arrayToPrint, string name = "")
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
        Console.Write(Math.Round(arrayToPrint[i],2));
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

double[]arrayToPrint =GenersteArray(10,-50,100);
PrintArray(arrayToPrint);