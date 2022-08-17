// Написать программу копирования массива
//Console.WriteLine("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine() ?? "0");

void CopyArray(int[] arr, int[] arr1, int size)
{   
    for(int i = 0; i < size; i++)
    {
      arr1[i] = arr[i]; 
      Console.Write($"{arr1[i]} ");
    }
}
int[] array = {45, 55, 3, 56, 7, 9, 87, 12, 2};
int length = array.Length;
int[] newarray = new int[length];
Console.Write("Новый скопированный массив newarray состоит из следующих элементов: ");
CopyArray(array, newarray, length);
Console.WriteLine();
