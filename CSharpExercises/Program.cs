using CSharpExercises;

Console.WriteLine("--- If Exercises ---");
Console.WriteLine($"Bill is 15 years old and he is {IfExercise.OldEnough(15)}"); // should be "a minor"
Console.WriteLine($"Stacy is 40 years old and she is {IfExercise.OldEnough(40)}"); // should be "old enough to vote"
Console.WriteLine();
Console.WriteLine($"Bob and Sue's names are {IfExercise.SameLength("Bob", "Sue")}"); // should be "the same length"
Console.WriteLine($"Sriram and Shigeru's names are {IfExercise.SameLength("Sriram", "Shigeru")}"); // should be "not the same length"
Console.WriteLine();
Console.WriteLine($"42 is {IfExercise.Modulo3(42)}"); // should be "divisible by three"
Console.WriteLine($"7 is {IfExercise.Modulo3(7)}"); // should be "remainder one"
Console.WriteLine($"88 is {IfExercise.Modulo3(86)}"); // should be "remainder two"
Console.WriteLine();
Console.WriteLine("--- While Exercises ---");
Console.WriteLine($"The first lowercase letter in cat is {WhileExercise.FirstLowercaseLetter("cat")}"); // should be 'c'
Console.WriteLine($"The first lowercase letter in Fred is {WhileExercise.FirstLowercaseLetter("Fred")}"); // should be 'r'
Console.WriteLine($"The first lowercase letter in iPod is {WhileExercise.FirstLowercaseLetter("iPod")}"); // should be 'i'
Console.WriteLine($"The first lowercase letter in XMLHttpRequest is {WhileExercise.FirstLowercaseLetter("XMLHttpRequest")}"); // should be 't'
Console.WriteLine();
Console.WriteLine($"The sum of the digits of 123 is {WhileExercise.SumOfDigits(123)}"); // should be 6
Console.WriteLine($"The sum of the digits of 666 is {WhileExercise.SumOfDigits(666)}"); // should be 18
Console.WriteLine($"The sum of the digits of 1248 is {WhileExercise.SumOfDigits(666)}"); // should be 15
Console.WriteLine();
Console.WriteLine($"How many consecutive capital letters does XML start with? There are {WhileExercise.ConsecutiveCapitalLetterCount("XML")}"); // should be 3
Console.WriteLine($"How many consecutive capital letters does California start with? There are {WhileExercise.ConsecutiveCapitalLetterCount("California")}"); // should be 1
Console.WriteLine($"How many consecutive capital letters does iOS start with? There are {WhileExercise.ConsecutiveCapitalLetterCount("iOS")}"); // should be 0
Console.WriteLine($"How many consecutive capital letters does JSONSerializer start with? There are {WhileExercise.ConsecutiveCapitalLetterCount("JSONSerializer")}"); // should be 5
Console.WriteLine();
Console.WriteLine("--- For Exercises ---");
Console.WriteLine($"Let's count up to 3! {ForExercise.CountUp(3)}"); // should be "123"
Console.WriteLine();
Console.WriteLine($"Let's count down from 9! {ForExercise.CountDown(9)}"); // should be "987654321"
Console.WriteLine();
Console.WriteLine($"Let's appreciate those even numbers between 1 and 9! {ForExercise.CountEven(1, 9)}"); // should be "2468"
Console.WriteLine();
Console.WriteLine("--- Foreach Exercises ---");
Console.WriteLine($"There are a lot of vowels in Mississippi! In fact there are {ForeachExercise.VowelCount("Mississippi")}"); // should be 4
Console.WriteLine($"Enqueue has a lot of vowels, too. It has {ForeachExercise.VowelCount("Enqueue")}"); // should be 5
Console.WriteLine($"Eau is French for water, and it's all vowels! It has {ForeachExercise.VowelCount("Eau")}"); // should be 3
Console.WriteLine();
Console.WriteLine($"Stan Smith works for the {ForeachExercise.Acronym("Central Intelligence Agency")}"); // should be "CIA"
Console.WriteLine();
Console.WriteLine($"The secret message says that Caesar will be betrayed by {ForeachExercise.CaesarCipher("BRUTUS")}"); // should be "CSVUVT"