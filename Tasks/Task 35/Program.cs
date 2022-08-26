int[] array = new int[123];
int count=0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 200);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if(array[j] > 0 & array[j] < 200) count = count + 1;
}
Console.WriteLine();
Console.Write("Количество чисел на отрезке [10,99] - ");
Console.Write(count);