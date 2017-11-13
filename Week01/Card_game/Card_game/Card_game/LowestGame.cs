using System;

namespace Card_game
{
    public class LowestGame : Game
    {
        public LowestGame() : base()
        {
        }

        public override void AnnounceWinner()
        {
            int lowestValue = players[0].TotalValueOfHand();
            Player winner = players[0];

            foreach (var player in players)
            {
                //Console.WriteLine(player.name);
                if (player.TotalValueOfHand() < lowestValue)
                {
                    //Console.WriteLine(player.name);
                    winner = player;
                }
            }
            Console.WriteLine("The winner is: " + winner.name);
        }
    }
}