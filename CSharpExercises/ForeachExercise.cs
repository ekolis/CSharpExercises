using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
	internal static class ForeachExercise
	{
		public static int VowelCount(string text)
		{
			// TODO: return the number of vowels (AEIOU, let's ignore Y for now, but check lowercase too) are in the text
			return -999;
		}

		public static string Acronym(string words)
		{
			// TODO: return the first letter of each word concatenated together, e.g. CIA for Central Intelligence Agency
			// HINT: use string.Split to split the string into words based on the spaces
			return "???";
		}

		public static string CaesarCipher(string message)
		{
			// TODO: return a string where each letter in the result is one past the corresponding letter from the message, wrapping around after Z
			// e.g. A becomes B, M becomes N, Z becomes A...
			return "???";
		}

		public static void Run()
		{
			Console.WriteLine("--- Foreach Exercises ---");
			Console.WriteLine($"There are a lot of vowels in Mississippi! In fact there are {VowelCount("Mississippi")}"); // should be 4
			Console.WriteLine($"Enqueue has a lot of vowels, too. It has {VowelCount("Enqueue")}"); // should be 5
			Console.WriteLine($"Eau is French for water, and it's all vowels! It has {VowelCount("Eau")}"); // should be 3
			Console.WriteLine();
			Console.WriteLine($"Stan Smith works for the {Acronym("Central Intelligence Agency")}"); // should be "CIA"
			Console.WriteLine($"People used to chat a lot on {Acronym("AOL Instant Messenger")}"); // should be "AIM"
			Console.WriteLine($"Smart people have a high {Acronym("Intelligence Quotient")}"); // should be "IQ"
			Console.WriteLine();
			Console.WriteLine($"The secret message says that Caesar will be betrayed by {CaesarCipher("BRUTUS")}"); // should be "CSVUVT"
			Console.WriteLine($"His coded response? {CaesarCipher("ETTU")}"); // should be "FUUV"
			Console.WriteLine($"If the Romans wanted to keep Jesus' identity a secret, his cross might have had the inscription {CaesarCipher("INRI")}"); // should be "JOSJ"
		}
	}
}
