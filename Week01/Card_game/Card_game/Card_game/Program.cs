using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new LowestGame();

            Player player1 = new Player("Nicolai");
            Player player2 = new WeakPlayer("Emil");
            Player player3 = new Player("Frederik");

            game.AcceptNewPlayer(player1);
            game.AcceptNewPlayer(player2);
            game.AcceptNewPlayer(player3);

            game.DealCards(5);

            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());
            Console.WriteLine(player3.ToString());

            game.AnnounceWinner();

        }
    }
}
