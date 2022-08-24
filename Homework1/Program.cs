/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/
using System;
class Program
{
static void FillArray(int []collection)
{
	int length = collection.Length;
	for(int i = 0; i < length; i++)
	{
		collection[i]= new Random().Next(100, 1000);
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
		int res = 0;
		for (int i = 0; i < length; i++)
		{
			if(array[i] % 2 == 0) res += 1;
		}
		PrintArray(array);
		Console.WriteLine();
		Console.Write("Количество четных чисел в массиве = {0}", res + ".");
	}
}








