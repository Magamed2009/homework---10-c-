List<bool> values = new List<bool>{ true, true, true };
bool evens = values.All(elem => elem );
Console.WriteLine("Are all the values in the list true? " + evens);