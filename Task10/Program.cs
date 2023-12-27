List<int> numbers = new List<int>();
var random = new Random();

for (int i = 0; i < 4; i++)
{
    int num = random.Next(1,50);
    numbers.Add(num); 
}
foreach (var item in numbers)
{
    System.Console.Write(item + " ");
}