/* task 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//Массив
int[]array= new int[20];
int evenNumbers = 0;


for (int i=0; i<array.Length; i++)
{   
    array[i]=new Random().Next(100,1000);
}
PrintArray(array);
   
void PrintArray(int[]array)
{
    for(int i=0; i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

//Четные числа в массиве
for (int i=0; i<array.Length; i++)
{
     if (array[i] %2 == 0)
     {
        Console.Write(array[i] + " ");
     evenNumbers ++;
     }
}

Console.WriteLine("There are "+ evenNumbers + " even numbers");
