﻿List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
numbers.Add(1);
foreach (var item in numbers)
{
    System.Console.Write(item + " ");
}