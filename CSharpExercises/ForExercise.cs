using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
	internal static class ForExercise
	{
		public static string CountUp(int end)
		{
			// TODO: return all the numbers from 1 to the ending number, concatenated together, e.g. 123
			return "???";
		}

		public static string CountDown(int start)
		{
			// TODO: return all the numbers from the starting number to 1, counting down, concatenated together, e.g. 321
			return "???";
		}

		public static string CountEven(int start, int end)
		{
			// TODO: return all the even numbers from start to end, counting up, concatenated together, e.g. 2468
			return "???";
		}

		public static void Run()
		{
			Console.WriteLine("--- For Exercises ---");
			Console.WriteLine($"Let's count up to 3! {CountUp(3)}"); // should be "123"
			Console.WriteLine();
			Console.WriteLine($"Let's count down from 9! {CountDown(9)}"); // should be "987654321"
			Console.WriteLine();
			Console.WriteLine($"Let's appreciate those even numbers between 1 and 9! {CountEven(1, 9)}"); // should be "2468"
		}
	}
}
