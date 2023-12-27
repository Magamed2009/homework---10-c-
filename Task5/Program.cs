List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
Console.WriteLine("The filtered numbers are:");
List<int> evens = numbers.FindAll(elem => elem % 2 == 0);
foreach(int number in evens)
{
 Console.WriteLine(number);
}