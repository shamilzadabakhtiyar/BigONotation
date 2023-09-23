int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Constant Time: O(1)
int FirstElement(int[] arr)
{
    return arr[0];
}

// Linear Time: O(n)
int Factorial(int n)
{
    var factorial = 1;
    for (int i = 1; i <= n; i++)
        factorial *= i;
    return factorial;
}

//Logarithm Time: O(log n)
int BinarySearch(int[] arr, int target)
{
    var firstIndex = 0;
    var lastIndex = arr.Length;
    while (firstIndex <= lastIndex)
    {
        var middleIndex = (int)Math.Floor((Decimal)((firstIndex + lastIndex) / 2));
        if (arr[middleIndex] == target)
            return middleIndex;

        if (arr[middleIndex] > target)
            lastIndex = middleIndex - 1;
        else
            firstIndex = middleIndex + 1;
    }
    return -1;
}

// Quadratic Time: O(n^2)
string MatchElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (i != j && arr[i] == arr[j])
                return $"Match found at {i} and {j}";
        }
    }
    return "No matches found";
}

// Exponential Time: O(2^n)
int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}