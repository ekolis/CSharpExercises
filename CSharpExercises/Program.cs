using CSharpExercises;

Console.WriteLine($"Bill is 15 years old and he is {IfExercise.OldEnough(15)}"); // should be "a minor"
Console.WriteLine($"Stacy is 40 years old and she is {IfExercise.OldEnough(40)}"); // should be "old enough to vote"

Console.WriteLine($"Bob and Sue's names are {IfExercise.SameLength("Bob", "Sue")}"); // should be "the same length"
Console.WriteLine($"Sriram and Shigeru's names are {IfExercise.SameLength("Sriram", "Shigeru")}"); // should be "not the same length"

Console.WriteLine($"42 is {IfExercise.Modulo3(42)}"); // should be "divisible by three"
Console.WriteLine($"7 is {IfExercise.Modulo3(7)}"); // should be "remainder one"
Console.WriteLine($"88 is {IfExercise.Modulo3(88)}"); // should be "remainder two"