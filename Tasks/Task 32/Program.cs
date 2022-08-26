int n = 4;
int[] CreateArray(int n)
{
    int[] array = new int[] { -4, -8, 8, 2};
    return array;
}
int[] GetOppositArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int[] array = CreateArray(n);
PrintArray(array);
PrintArray(GetOppositArray(array));
