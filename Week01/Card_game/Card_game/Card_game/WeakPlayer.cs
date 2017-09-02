using System.Collections.Generic;

namespace Card_game
{
    public class WeakPlayer : Player
    {
        public WeakPlayer(string name) : base(name)
        {
        }

        public override void AddCard(Card card)
        {
            if(hand.Count < 3)
                hand.Add(card);
        }
    }
}