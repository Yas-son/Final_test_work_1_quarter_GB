int[] a = {-4,-3,-2,-1,0,1,2,3,4};

for (int i = 0; i < a.Length; i++)
{
    if ((a[i] % 2) == 0)
    {
        Console.Write($"{a[i]} ");
    }
}

//Dotnet run: -4 -2 0 2 4