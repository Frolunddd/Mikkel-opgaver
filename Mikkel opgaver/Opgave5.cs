//OPGAVE 5
/*
using System.Diagnostics;

int[] arr;
arr = new int[6] {7, 37, 11, 5, 2, 26};


int[] Sorteret(int[] arr)
{
    int a = -1;
    int b = 0;
    while (b < arr.Length-1)
    {
        b++;
        a++;
        int tal1 = arr[a];
        int tal2 = arr[b];
        if (arr[a] > arr[b])
        {
            arr[a] = tal2;
            arr[b] = tal1;
            a = -1;
            b = 0;
        }
    }
    return arr;
}
int[] gemmer = Sorteret(arr);
for (int i = 0; i < gemmer.Length; i++)
{
    Console.WriteLine(gemmer[i]);
}
*/