using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rand = new Random();
			int correctCount = 0;
			int numberOfFlips = 0;
			string headsOrTailsGuess = "";

			Console.WriteLine("Guess which will have more: heads or tails?");
			headsOrTailsGuess = Console.ReadLine().ToLowerInvariant();
			Console.WriteLine("How many times shall we flip a coin?");
			numberOfFlips = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < numberOfFlips; i++)
			{
				int flip = rand.Next(100);
				if (flip < 50)
				{
					// tails
					Console.WriteLine("tails");
					if ("tails" == headsOrTailsGuess)
					{
						correctCount = correctCount + 1;
					}
				}
				else
				{
					// heads
					Console.WriteLine("heads");
					if ("heads" == headsOrTailsGuess)
					{
						correctCount = correctCount + 1;
					}
				}
			}
			Console.WriteLine("Your guess, " + headsOrTailsGuess + ", " + "came up " + Convert.ToString(correctCount) + " time(s).");
			Console.WriteLine("That's " + Convert.ToString(100 * correctCount / numberOfFlips) + "%.");
		}
    }
}
