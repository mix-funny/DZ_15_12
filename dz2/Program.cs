// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArray(int number)
{
    int [] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(-100,100);
        i ++;
    }
    return array;
}

void PrintArray(int [] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    } 
}

Console.WriteLine("Выбор размера массива... ");
Console.WriteLine("Подборка элементов массива... ");
int number = new Random().Next(5,11);
int [] array = new int[number];
array = CreateArray(number);
Console.WriteLine("Массив сгенерирован... ");
Console.WriteLine(" ");
PrintArray(array);


int Sum (int [] array)
{
    int index = 0;
    int sum = 0;
    while(index < array.Length)
    {
        if(index%2 != 0)
        {
            sum+=array[index];
        }
        index++;
    
    }
    return sum;
}
Console.WriteLine(" ");
Console.WriteLine("Сумма всех элементов данного массива " + Sum(array));
