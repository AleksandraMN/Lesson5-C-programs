/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

using System;
class Program
{
static void FillArray(double []collection)
{
	int length = collection.Length;
	for(int i = 0; i < length; i++)
	{
		collection[i]= new Random().Next(0, 100);
	}
}
static void PrintArray(double [] array)
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
		double [] array  = new double [4];
		FillArray(array);
		int length = array.Length;
		double result = 0;
		double max = array[0];
		double min = array[0];
		for (int i = 1; i < length; i++)
		{
			if(array[i] > max) max = array[i];
			if(array[i] < min) min = array[i];
		}
		result = max - min;
		PrintArray(array);
		Console.WriteLine();
		Console.Write("Разница между максимальным и минимальным элементами массива = {0}", result + ".");
	}
}











