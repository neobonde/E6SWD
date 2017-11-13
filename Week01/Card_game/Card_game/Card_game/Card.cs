using System;

namespace Card_game
{
    public class Card
    {
        public enum Suits
        {
            Red = 1,
            Blue,
            Green,
            Yellow,
        }

        public Suits Suit { get; }
        public int Number { get; }

        public int Value { get; protected set; }

        public Card()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            Suit = (Suits) r.Next(1, 4);
            Number = r.Next(1, 8);

            Value = Number * (int)Suit;
        }

        public override string ToString()
        {
            return this.Suit.ToString() + " " + this.Number + ", value: " + this.Value;
        }
    }
}