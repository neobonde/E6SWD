using System;
using System.Collections.Generic;

namespace Card_game
{
    public class Game
    {

        protected List<Player> players = new List<Player>();
        protected Deck gameDeck;

        public Game()
        {
        }

        public void AcceptNewPlayer(Player player)
        {
            players.Add(player);
        }

        public void DealCards(int amount)
        {
            gameDeck = new Deck(amount*players.Count);

            Console.WriteLine(gameDeck.ToString());

            for (int i = 0; i < amount; i++)
            {
                foreach (var player in players)
                {
                    Card temp = gameDeck.dealCard();
                    player.AddCard(temp);
                }
            }
        }

        public virtual void AnnounceWinner()
        {
            int higestValue = players[0].TotalValueOfHand();
            Player winner = players[0];

            foreach (var player in players)
            {
                //Console.WriteLine(player.name);
                if (player.TotalValueOfHand() > higestValue)
                {
                    //Console.WriteLine(player.name);
                    winner = player;
                }
            }
            Console.WriteLine("The winner is: " + winner.name);
        }

    }
}