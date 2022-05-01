/*
int NaturalSum(int a)
{
    int sum = 0;

    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++) sum += i;
    }
    return sum;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalSum(num));
*/


//Создание случайного массива.
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

// Возврат значений массива

void ShowArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


void FindSumOfElements(int[] array)
{
    int plussum = 0;
    int minussum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            plussum += array[i];
        else 
            minussum += array[i];
    }
    Console.WriteLine ("Sum of positive elements " + plussum);
    Console.WriteLine ("Sum of negative elements " + minussum);
}


int[] myArray = CreateRandomArray(6, -5, 5);
ShowArray(myArray);
FindSumOfElements(myArray);