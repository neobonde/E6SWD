using System.Collections.Generic;

namespace Card_game
{
    public class Player
    {
        protected List<Card> hand = new List<Card>();
        public string name { get; } 


        public Player(string name)
        {
            this.name = name;
        }

        public string showHand()
        {
            string result = "";
            foreach (var card in hand)
            {
                result += card.ToString() + "\n";
            }
            return result += "Total Value: " + TotalValueOfHand() + "\n\n";
        }

        public override string ToString()
        {
            return name + "\n" + showHand();
        }

        public virtual void AddCard(Card card)
        {
            hand.Add(card);
        }

        public int TotalValueOfHand()
        {
            int result = 0;
            foreach (var card in hand)
            {
                result += card.Value;
            }

            return result;
        }

    }
}