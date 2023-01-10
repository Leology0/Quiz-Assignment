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
string answer1 = Console.ReadLine();

// Question 2
Console.WriteLine("2.How many Pokemon are in the Pokemon Scarlet and Violet Pokedex");
Console.Write("Q2 Answer:");
string answer2 = Console.ReadLine();

// Question 3
Console.WriteLine("3.In what games was mega evolution for Pokemon introduced");
Console.Write("Q3 Answer:");
string answer3 = Console.ReadLine();

// Question 4
Console.WriteLine("4.What Pokemon was Ash Ketchum's partner in the popular Pokemon show");
Console.Write("Q4 Answer:");
string answer4 = Console.ReadLine();

// Check Answers
if (answer1 == "charmander") {
    score++;
}
if (answer2 == "400") {
    score++;
}
if (answer3 == "pokemon x and y") {
    score++;
}
if (answer4 == "pikachu") {
    score++;
}

// Evaluate Score
Console.WriteLine("YOUR RESULTS:");

if (score == 4) {
    
}

