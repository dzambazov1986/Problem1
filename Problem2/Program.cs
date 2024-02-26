int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

// Calculate the average value of the elements in the middle of the array
int midIndex = numbers.Length / 2;
double average = (numbers[midIndex - 1] + numbers[midIndex]) / 2.0;

// Print the result formatted to the second digit
Console.WriteLine($"{average:F2}");