using System;

namespace ManyMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			hello();
			addition();
			catDog();
			oddEvent();
			inches();
			echo();
			killGrams();
			date();
			age();
			guess();

		}
		static void hello()
		{
			Console.WriteLine("Hello, What is your name?");
			string name = Console.ReadLine();
			Console.WriteLine("Bye {0}!", name);

		}

		static void addition()
		{
			Console.WriteLine("Whats your first number?");
			int addition1 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Whats your second number?");
			int addition2 = Int32.Parse(Console.ReadLine());
			int sum = addition1 + addition2;
			Console.WriteLine(sum);
		}
		static void catDog()
		{
			Console.WriteLine("Do you prefer cats or dogs?");
			string Answer = Console.ReadLine();
			if (Answer.ToUpper() == "CATS")
			{
				Console.WriteLine("meow");
			}
			else
			{
				Console.WriteLine("Bark");
			}
		}


		static void oddEvent()
		{
			Console.WriteLine("Give me a number and ill tell you if its even or odd");
			int oddEvent = Int32.Parse(Console.ReadLine());
			if (oddEvent % 2 == 0)
			{
				Console.WriteLine("your number is even!");
			}
			else
			{
				Console.WriteLine("your number is Odd!");
			}
		}

		static void inches()
		{
			Console.WriteLine("Give me a height in feet and i will convert it to inches");
			int feet = Int32.Parse(Console.ReadLine());
			int inches = 12 * feet;
			Console.WriteLine(inches);
		}
		static void echo() {
			Console.WriteLine("Give me a word!");
			string echo = Console.ReadLine();
			Console.WriteLine(echo.ToUpper());
			Console.WriteLine(echo.ToLower());
			Console.WriteLine(echo.ToLower());

		}
		static void killGrams() {
			Console.WriteLine("Give me a weight in pounds");
			double pounds = Convert.ToDouble(Console.ReadLine());
			double killograms = 2.205 / pounds;
			Console.WriteLine(killograms);
		}

		static void date()
		{
			Console.WriteLine(DateTime.Now);

		}
		static void age() {
			Console.WriteLine("Give me your birth year");
			string age = Console.ReadLine();
			int age1 = Int32.Parse(age);
			int age2 = 2020 - age1;
			Console.WriteLine(age2);
		}
		static void guess() {
			Console.WriteLine("Guess a word!");
			string guess = Console.ReadLine();
			if (guess == "chsarp")
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				Console.WriteLine("WRONG!!");
			}


		}




	}




}
