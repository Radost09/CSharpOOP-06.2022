using System;
using System.Collections.Generic;

namespace P03Cards
{
    public class Card
    {
        private Dictionary<string, char> cardSuits = new Dictionary<string, char>
        {
            { "D" , '\u2666'},
            { "C", '\u2663'},
            { "H", '\u2665'},
            { "S", '\u2660'}
        };

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        public string Face { get; set; }
        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{Face}{cardSuits[Suit]}]";
        }
    }

    public enum SuitValue
    {
        D, C, H, S
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = new List<Card>();
            string[] cards = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var cardInfo in cards)
            {
                Card card = null;

                try
                {
                    string[] cardData = cardInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    card = CreateCard(cardData[0], cardData[1]);
                    deck.Add(card);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(string.Join(' ', deck));
        }

        private static Card CreateCard(string face, string suit)
        {
            List<string> faceValues = new List<string>
                { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            if (!faceValues.Contains(face))
            {
                throw new ArgumentException("Invalid card!");
            }
            if (!Enum.IsDefined(typeof(SuitValue), suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            return new Card(face, suit);
        }
    }
}
