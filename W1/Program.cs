/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

Console.Write("Enter lenght array: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = FillArray(lenght);
Console.WriteLine($"[{string.Join(", ",array)}] - > {GetCountEvenNumbersArray(array)}");


int[] FillArray(int countIndex)
{
	Random random = new Random();
	int[] array = new int[countIndex];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(100, 1000);
	}
	return array;
}

int GetCountEvenNumbersArray(int[] array)
{
	int countEven = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] % 2 == 0)
		countEven++;
	}
	return countEven;
}