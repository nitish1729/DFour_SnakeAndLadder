

  // The Player rolls the die	to get a number between 1 to 6.
  // between 1 to 6. - Use ((RANDOM)) to get the number between

	string Snake_Ladder;
	Snake_Ladder = "Welcome to the Snake & Ladder Simulator";
	Console.WriteLine(Snake_Ladder);
	Console.WriteLine("------------------------------------");
	Console.WriteLine("Enter the player name :");
	string player = Console.ReadLine();
	int start = 0;
	int position = start;
	int Noplay = 0;
	Random ran = new Random(0);
	int rolls_die = ran.Next(0, 7);
	Console.WriteLine("Play name is : {0}", player + " , "

						  + player + "  " + "got the number : " + rolls_die);
	int newposition = position + rolls_die;
	Console.WriteLine("player new position is : " + newposition);
	int Ladder = position + newposition;
	int snake = Ladder - newposition;

		if (rolls_die == Noplay)
		{
			Console.WriteLine("Player stay in the same position");
		}
		else if (rolls_die == 4)
		{
			Console.WriteLine("player jumped ahead by : " + Ladder);
		}
		else if (rolls_die == 3)
		{
			Console.WriteLine("player jumped behind by : " + snake);
		}
		else
		{
			Console.WriteLine("player moves ahead ");

		}
