// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(GetFizzBuzz(i));
}

string GetFizzBuzz(int number)
{
    if (number % 15 == 0) return "FizzBuzz";
    if (number % 3 == 0) return "Fizz";
    if (number % 5 == 0) return "Buzz";
    return number.ToString();
}
