int[] array = {3, 7, 22, 2, 78};
int max = array[0];
int min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом: ");
Console.Write(max - min);
