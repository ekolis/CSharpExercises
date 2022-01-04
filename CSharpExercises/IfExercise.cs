using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
	internal static class IfExercise
	{
		public static string OldEnough(int age)
		{
			// TODO: return "old enough to vote" if the age is at least 18, otherwise return "a minor".
			return "???";
		}

		public static string SameLength(string a, string b)
		{
			// TODO: return "the same length" if the two strings have the same length, otherwise return "not the same length".
			return "???";
		}

		public static string Modulo3(int num)
		{
			// TODO: return "divisible by three" if the number is divisible by 3, "remainder one" if the remainder is 1, and "remainder two" if the remainder is 2
			return "???";
		}

		public static void Run()
		{
			Console.WriteLine("--- If Exercises ---");
			Console.WriteLine($"Bill is 15 years old and he is {OldEnough(15)}"); // should be "a minor"
			Console.WriteLine($"Stacy is 40 years old and she is {OldEnough(40)}"); // should be "old enough to vote"
			Console.WriteLine();
			Console.WriteLine($"Bob and Sue's names are {SameLength("Bob", "Sue")}"); // should be "the same length"
			Console.WriteLine($"Sriram and Shigeru's names are {SameLength("Sriram", "Shigeru")}"); // should be "not the same length"
			Console.WriteLine();
			Console.WriteLine($"42 is {Modulo3(42)}"); // should be "divisible by three"
			Console.WriteLine($"7 is {Modulo3(7)}"); // should be "remainder one"
			Console.WriteLine($"88 is {Modulo3(86)}"); // should be "remainder two"
		}
	}
}
