// Sorting array

int[] array = {45, 78, 12, 94, 63, 27, 39, 85, 10, 56, 32, 71, 99, 14, 47, 82, 68, 33, 19, 54};

Console.Write("Unsorted array: ");
foreach (int item in array) {
    Console.Write($"{item} ");
}
Console.WriteLine("\n");

for (int i = 0; i < array.Length; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if(array[i] > array[j]) {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}

Console.Write("Sorted array: ");
foreach (int item in array) {
    Console.Write($"{item} ");
}
Console.WriteLine("\n");


// Finding Frequency of Elements

int?[] array2 = {2, 3, 2, 4, 3, 3, 5};

for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] != null) {
        int occurrence = 0;
        int elementToFind = Convert.ToInt32(array2[i]);
        for (int j = 0; j < array2.Length; j++)
        {
            if(elementToFind == array2[j]) { 
                occurrence++; 
                array2[j] = null;
            }
        }
        Console.WriteLine($"Element {elementToFind} accurs {occurrence} times.");
    }
}
Console.WriteLine();

// Multidimensional Array - Matrix Addition

int[,] matrix1 = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};
int[,] matrix2 = {
    {9, 8, 7},
    {6, 5, 4},
    {3, 2, 1}
};

int[,] matrixSum = new int[3,3];

for (int i = 0; i < matrix1.GetLength(0); i++) {
    for (int j = 0; j < matrix1.GetLength(1); j++) {
        matrixSum[i,j] = matrix1[i,j] + matrix2[i,j];
    }
}

Console.WriteLine("Matrix sum:");
for (int i = 0; i < matrixSum.GetLength(0); i++) {
    for (int j = 0; j < matrixSum.GetLength(1); j++) {
        Console.Write($"{matrixSum[i,j]}\t");
    }
    Console.WriteLine();
}
