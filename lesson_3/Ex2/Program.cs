// Найти позицию минимального элемента в неотсортированной части массива.
//  Произвести обмен этого значения со значением первой неотсортированной позиции.
// Повторять пока есть неотсортированные элементы.

// int [] arr = {1, 3, 4, 5, 6, 4, 1, 1};

// void PrintArray(int [] array);
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
PtintArray(arr);

