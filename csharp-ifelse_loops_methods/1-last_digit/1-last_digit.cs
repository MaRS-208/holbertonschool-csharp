using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	int lastNum = number % 10;
	if (lastNum > 5)
	{
		Console.WriteLine($"The last digit of {number} is {lastNum} and is greater than 5");
	}
	else if(lastNum < 6 && lastNum != 0)
	{
		Console.WriteLine($"The last digit of {number} is {lastNum} and is less than 6 and not 0");
	}
	else if (lastNum == 0)
	{
		Console.WriteLine($"The last digit of {number} is {lastNum} and is 0");
	}
    }
}
