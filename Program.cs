// See https://aka.ms/new-console-template for more information

using CodeWarsSolutions;

Console.WriteLine("Hello, World!");
Console.WriteLine(ToWeirdCase.ChangeToWeirdCase("this is a test"));

List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };

Console.WriteLine(NumberOfPeopleInTheBus.Number(peopleList));
