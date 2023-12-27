List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
numbers.Remove(1);
foreach (var item in numbers)
{
    System.Console.Write(item + " ");    
}