using parantez;
Console.WriteLine("enter input: ");
var input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input) || input.Length % 2 != 0)
    Console.WriteLine(false);
else
    Console.WriteLine(Checker.Check(input));