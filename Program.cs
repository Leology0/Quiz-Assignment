// Quiz Assignment by Leo
#nullable disable
Console.Clear();

// Welcome
Console.WriteLine("WELCOME TO THE POKEMON QUIZ");

//Variables
int score = 0;

// Inputs
// Question 1
Console.WriteLine("1.What is the gen 1 fire type starter");
Console.Write("Q1 Answer:");
string answer1 = Console.ReadLine().ToLower();
// Check answer 1
if (answer1 == "charmander") {
    score++;
    Console.WriteLine("Correct");
}
// Question 2
Console.WriteLine("\n2.How many Pokemon are in the Pokemon Scarlet and Violet Pokedex");
Console.Write("Q2 Answer:");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "400") {
    score++;
    Console.WriteLine("Correct");
}

// Question 3
Console.WriteLine("\n3.In what games were mega evolution for Pokemon introduced");
Console.Write("Q3 Answer:");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "pokemon x and y") {
    score++;
    Console.WriteLine("Correct");
}

// Question 4
Console.WriteLine("\n4.What Pokemon was Ash Ketchum's partner in the popular Pokemon show");
Console.Write("Q4 Answer:");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "pikachu") {
    score++;
    Console.WriteLine("Correct");
}

// Evaluate Score
Console.WriteLine("\nYOUR RESULTS:");

if (score == 4) {
    Console.WriteLine($"4 / 4 (100%)");
    Console.WriteLine("A Perfect Score!");
} else if (score == 3) {
    Console.WriteLine($"3 / 4 (75%)");
    Console.WriteLine("Almost!");
} else if (score == 2) {
    Console.WriteLine($"2 / 4 (50%)");
    Console.WriteLine("Halfway there.");
} else if (score == 1) {
    Console.WriteLine($"1 / 4 (25%)");
    Console.WriteLine("Nice Try.");
} else {
    Console.WriteLine($"0 / 4 (0%)");
    Console.WriteLine("Better luck next time."); 
}

