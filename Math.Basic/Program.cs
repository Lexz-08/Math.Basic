using Math.Basic;
using System;

namespace Math_Basic_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Math.Basic Console";

			// give the user different operation options
			Console.WriteLine("\tPlease enter a math operation to perform:");
			Console.WriteLine("\n\t1) Addition");
			Console.WriteLine("\n\t2) Subtraction");
			Console.WriteLine("\n\t3) Multiplication");
			Console.WriteLine("\n\t4) Division");
			Console.WriteLine("\n\t5) Exponential");
			Console.WriteLine("\n\t6) Modulus");
			Console.WriteLine("\n\t----------------------------------------------------------\n");

			// get the user's input
			int userChoice = GetUserInput();

			// perform a math operation (just floats for now)
			
		}

		private static int GetUserInput()
		{
			int userChoice = 0;

			try
			{
				Console.Write("\nOperation Choice (Whole Number 1-6 Only): ");
				int choice = int.Parse(Console.ReadLine());

				if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6)
					userChoice = choice;
				else
				{
					Console.WriteLine("\nInvalid respone. Please enter a valid option.");
					Console.ReadKey();
					Console.Clear();
					userChoice = GetUserInput();
				}
			}
			catch
			{
				Console.WriteLine("\nInvalid respone. Please enter a valid option.");
				Console.ReadKey();
				Console.Clear();
				userChoice = GetUserInput();
			}

			return userChoice;
		}
	}
}
