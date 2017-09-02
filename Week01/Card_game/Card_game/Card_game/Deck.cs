using System.Collections.Generic;

namespace Card_game
{
    public class Deck
    {
        private Queue<Card> cards;

        public Deck(int deckSize)
        {
            cards = new Queue<Card>(deckSize);
            for (int i = 0; i < deckSize; i++)
            {
                cards.Enqueue(new Card());
            }
        }

        public override string ToString()
        {
            string result = "Deck Size: " + cards.Count + "\n{\n";
            foreach (var deckCard in this.cards)
            {
                result += deckCard.ToString() + "\n";
            }
            result += "}";
            return result;
        }

        public Card dealCard()
        {
            //List<Card> cardsToDeal = new List<Card>(amount);
            //for (int i = 0; i < amount; i++)
            //{
            //    cardsToDeal.Add(cards.Dequeue());
            //}
            //return cardsToDeal;
            Card temp = cards.Dequeue();
            return temp;
        }
    }
}