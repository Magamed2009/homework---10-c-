List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
int cnt = numbers.Find(elem => elem == 6);
System.Console.WriteLine(cnt);