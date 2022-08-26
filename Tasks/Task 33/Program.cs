Console.Write("Введите число: ");
int[] intArray;
intArray = new int[] { 6, 7, 19, 345, 3};
int number = Convert.ToInt32(Console.ReadLine());
int x = number;

string Result = "отсутствует";
bool FindNumber(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x) return true;
    }
    return false;
}
void PrinArray(int[] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
PrinArray(intArray);
if (FindNumber(intArray, number)) Result = "присутствует";
System.Console.WriteLine($"Число {number} {Result} в массиве");
System.Console.WriteLine();
