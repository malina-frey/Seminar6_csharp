/*
Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: 
каждая сторона треугольника меньше суммы двух других сторон.
*/



int[] arraySides()
{
    int[] result = new int[3];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

bool compareSides(int[] array)
{
    bool result = false;
    if (    array[0] + array[1] > array[2]
    &&      array[1] + array[2] > array[0]
    &&      array[0] + array[2] > array[1])
    {
       result =true;
    }
    return result;
    
}

int[] array = arraySides();
bool result = compareSides(array);
Console.WriteLine(result);

//Console.WriteLine("да");
//Console.WriteLine("нет");