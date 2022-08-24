/*
Задача 37. Найдите произведение  пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве:
[1 2 3 4 5] - 5 8 3.
[6 7 3 6] - 36 21.
*/

using System;
class Program
{
	static void FillArray(int []collection)
{
	int length = collection.Length;
	for(int i = 0; i < length; i++)
	{
		collection[i]= new Random().Next(1, 7);
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
		int [] array1  = new int [5];
		int [] array2  = new int [(array1.Length+1)/2];
		FillArray(array1);
		int result = 0;
		for (int i = 0; i <= (array1.Length-1)/2; i++)
		{
				result = array1[i] * array1[(array1.Length-1)-i];
				array2[i] = result;
				if(i == (array1.Length-1)-i) result = array1[i] = array2[i]; 
		}
		Console.Write("Одномерный массив = "); 
		PrintArray(array1);
		Console.WriteLine();

		Console.Write("Произведение пар чисел в одномерном массиве(парой считаем первый и последний элемент, второй и предпоследний и т.д.) = ");
		PrintArray(array2);
	}
}








