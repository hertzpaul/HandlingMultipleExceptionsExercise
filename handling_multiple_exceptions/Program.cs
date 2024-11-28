
class Program
{
    static void Main(string[] args)
    {
        HandleMultipleExceptions("2", 1);
        HandleMultipleExceptions("abc", 1);
        HandleMultipleExceptions("2", 5); 
    }

    static void HandleMultipleExceptions(string inputString, int index)
    {
        int[] numbers = { 1, 2, 3 };

        try
        {
            int parsedValue = int.Parse(inputString);
            Console.WriteLine(numbers[index]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range");
        }
    }
}