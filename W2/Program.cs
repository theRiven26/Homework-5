/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

Console.Write("Enter lenght array: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = FillArray(lenght);
Console.WriteLine($"[{string.Join(", ",array)}] - > {GetSumOddIndexArray(array)}");
int[] FillArray(int countIndex)
{
	Random random = new Random();
	int[] array = new int[countIndex];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(-99, 100);
	}
	return array;
}


int GetSumOddIndexArray(int[] array)
{
	int sum = 0;
	for (int i = 1; i < array.Length; i += 2)
	{
		sum += array[i];
	}
	return sum;
}