// CREATE A QUIZ
#nullable disable
Console.Clear();

//WELCOME
Console.WriteLine("Welcome to the JoJo's Bizzare Adventure Quiz");

//Answer Var
double answerVal = 0;

//Q1
Console.WriteLine("\n1. Who is the Main Protaganist of Part 3?");
Console.Write("Q1 Answer: ");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "jotaro kujo" ||
 answer1 == "jotaro" || 
 answer1 == "kujo jotaro" ||
 answer1 == "professor kujo" ||
 answer1 == "qtaro kujo") {
Console.WriteLine("Correct");
answerVal++;
} else {
Console.WriteLine("Incorrect");
}

//Q2
Console.WriteLine("\n2. Who is the Main Villan of Part 4?");
Console.Write("Q2 Answer: ");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "yoshikage kira" ||
 answer2 == "kira" ||
  answer2 == "kira yoshikage") {
Console.WriteLine("Correct");
answerVal++;
} else {
Console.WriteLine("Incorrect");
}

//Q3
Console.WriteLine("\n3. Who is Giorno's Father?");
Console.Write("Q3 Answer: ");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "dio" ||
 answer3 == "dio brando") {
Console.WriteLine("Correct");
answerVal++;
} else {
Console.WriteLine("Incorrect");
}

//Q4
Console.WriteLine("\n4. How Many Acts does Echos Have in Part 4?");
Console.Write("Q4 Answer: ");
int answer4 = Convert.ToInt32(Console.ReadLine().ToLower());
if (answer4 == 3) {
Console.WriteLine("Correct");
answerVal++;
} else {
Console.WriteLine("Incorrect");
}

//RESULTS 
Console.WriteLine("\nYOUR RESULTS:");
Console.WriteLine($"{answerVal} / 4 ({(answerVal/4)*100}%)");
if (answerVal == 4){
    Console.WriteLine("Perfect!");
} else if (answerVal == 3) {
Console.WriteLine("Good Job!");
} else if (answerVal == 2) {
Console.WriteLine("Your Half way there!");
} else if (answerVal == 1) {
Console.WriteLine("You should Try Harder.");
} else {
Console.WriteLine("Do you even know what JOJO's is?");
}
