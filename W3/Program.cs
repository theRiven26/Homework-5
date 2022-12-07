/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Write("Enter lenght array: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = FillArray(lenght);

MinMaxNumbersArray(array, out int min, out int max);
Console.WriteLine($"{string.Join(", ", array)} -> {max - min}");

int[] FillArray(int countIndex)
{
	Random random = new Random();
	int[] array = new int[countIndex];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(0, 100);
	}
	return array;
}

void MinMaxNumbersArray(int[] array, out int min, out int max)
{
	max = array[0];
	min = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array[i];
		}
		else if (array[i] < min)
		{
			min = array[i];
		}
	}
}