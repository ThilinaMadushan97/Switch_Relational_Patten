List<int> numbers = new List<int> { 10, -2, 31, 5, 0, 22 };

foreach (int num in numbers)
{
    var result = num switch
    {
        > 0 => $"{num} is a positive number",
         0 => $"Zero",
        < 0 => $"{num} is a negative number"

    };
    Console.WriteLine(result);
}
