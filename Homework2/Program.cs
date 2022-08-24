/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

using System;
class Program
{
static void FillArray(int []collection)
{
	int length = collection.Length;
	for(int i = 0; i < length; i++)
	{
		collection[i]= new Random().Next(-5, 13);
	}
}
static void PrintArray(int [] array)
{
	int index = array.Length;
	Console.Write("[");
	for(int i = 0; i < index; i++)
	{
		Console.Write(" {0} ", array[i]);
		
	}
	Console.Write("]");
}
static void Main(string[] args)
	{
		int [] array  = new int [4];
		FillArray(array);
		int length = array.Length;
		int sum = 0;
		for (int i = 0; i < length; i++)
		{
			if(i % 2 != 0) sum += array[i];
		}
		PrintArray(array);
		Console.WriteLine();
		Console.Write("Сумма элементов, стоящих на нечётных позициях = {0}", sum + ".");
	}
}




