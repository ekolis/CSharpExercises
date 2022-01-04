using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
	internal static class WhileExercise
	{
		public static char FirstLowercaseLetter(string text)
		{
			// TODO: return the first lowercase letter in the string
			return '?';
		}

		public static int SumOfDigits(int num)
		{
			// TODO: return the sum of the digits of the number
			return -999;
		}

		public static int ConsecutiveCapitalLetterCount(string word)
		{
			// TODO: return the number of consecutive capital letters in the word, starting from the first letter
			return -999;
		}

		public static void Run()
		{
			Console.WriteLine("--- While Exercises ---");
			Console.WriteLine($"The first lowercase letter in cat is {FirstLowercaseLetter("cat")}"); // should be 'c'
			Console.WriteLine($"The first lowercase letter in Fred is {FirstLowercaseLetter("Fred")}"); // should be 'r'
			Console.WriteLine($"The first lowercase letter in iPod is {FirstLowercaseLetter("iPod")}"); // should be 'i'
			Console.WriteLine($"The first lowercase letter in XMLHttpRequest is {FirstLowercaseLetter("XMLHttpRequest")}"); // should be 't'
			Console.WriteLine();
			Console.WriteLine($"The sum of the digits of 123 is {SumOfDigits(123)}"); // should be 6
			Console.WriteLine($"The sum of the digits of 666 is {SumOfDigits(666)}"); // should be 18
			Console.WriteLine($"The sum of the digits of 1248 is {SumOfDigits(666)}"); // should be 15
			Console.WriteLine();
			Console.WriteLine($"How many consecutive capital letters does XML start with? There are {ConsecutiveCapitalLetterCount("XML")}"); // should be 3
			Console.WriteLine($"How many consecutive capital letters does California start with? There are {ConsecutiveCapitalLetterCount("California")}"); // should be 1
			Console.WriteLine($"How many consecutive capital letters does iOS start with? There are {ConsecutiveCapitalLetterCount("iOS")}"); // should be 0
			Console.WriteLine($"How many consecutive capital letters does JSONSerializer start with? There are {ConsecutiveCapitalLetterCount("JSONSerializer")}"); // should be 5
		}
	}
}
