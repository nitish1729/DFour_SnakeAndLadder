
// Snake and Ladder game played with single player at start position 0	

string Snake_Ladder;
Snake_Ladder = "Welcome to the Snake & Ladder Simulator";
Console.WriteLine(Snake_Ladder);
Console.WriteLine("------------------------------------");

Console.WriteLine("Enter the player name");
// Console.ReadLine() to get user input
string player = Console.ReadLine();

const int start = 0; // Constant- start position 
int position = start;
Console.WriteLine("Play name is : {0}", player + "  " +player + "is on: " + position + " - " + "Position");
