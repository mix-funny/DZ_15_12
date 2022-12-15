// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] CrArray(int number)
{
    int [] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(100,1000);
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

Console.WriteLine("Компьютер выбирает размер массива... ");
Console.WriteLine("Компьютер подбирает элементы массива... ");
int number = new Random().Next(1,11);
int [] array = new int[number];
array = CrArray(number);
Console.WriteLine("Массив сгенерирован... ");
Console.WriteLine(" ");
PrintArray(array);


int EvenElements(int [] array)
{
    int index = 0; 
    int counter = 0;
    while(index < array.Length)
    {
        if(array[index]%2 == 0)
        {
         counter++;
        }
        index++;
    }
    return counter;
}
Console.WriteLine(" ");
Console.WriteLine("Количество чётных элементов в массиве "+ EvenElements(array));
