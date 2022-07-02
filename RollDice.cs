

 // The Player rolls the die	to get a number between 1 to 6.
 // between 1 to 6. - Use ((RANDOM)) to get the number between 1 to 6

   Console.WriteLine("Hello, World!");
    
    string Welcome = " Welcome to Snake And ladder Simulator";
    Console.WriteLine(Welcome);
    Console.WriteLine(".........................................");

    string Snake_Ladder;
	Snake_Ladder = "Welcome to the Snake & Ladder Simulator";
	Console.WriteLine(Snake_Ladder);
	Console.WriteLine("------------------------------------");
	Console.WriteLine("Enter the player name :");
	string player = Console.ReadLine();
	Random ran = new Random(0);
	int rolls_die = ran.Next(1, 7);
	Console.WriteLine("Play name is : {0}", player + " , "
						  + player + "  " + "got the number : " + rolls_die);
