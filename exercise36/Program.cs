/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//Массив
int[]array= new int[5];
int sumNumbers = 0;


for (int i=0; i<array.Length; i++)
{   
    array[i]=new Random().Next(int.MinValue,int.MaxValue);
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

//Сумма чисел на нечетных позициях в массиве
for (int i = 0; i<array.Length; i++)
{
    if (i % 2 != 0)
      {
        sumNumbers = sumNumbers + array[i];
      }
}

Console.WriteLine("Answer is: " + sumNumbers);


