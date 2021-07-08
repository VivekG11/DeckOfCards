using System;

namespace DeckOfCards
{
    class Program
    {
        static string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        static string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "King", "Queen", "Jack", "Ace" };
        static int totNumOfCards = suits.Length * ranks.Length;
        static string[] cards = new string[totNumOfCards];

        public void shuffleCards()
        {
            Random rand = new Random();
            for(int i = 0; i<totNumOfCards; i++)
            {
                int a = rand.Next(0, totNumOfCards);
                String temp = cards[a];
                cards[a] = cards[i];
                cards[i] = temp;
            }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Deck of cards.....");
            for (int i = 0; i < ranks.Length; i++)
            {
                for(int j = 0; j < suits.Length; j++)
                {
                    cards[suits.Length * i + j] = ranks[i] + "of " + suits[j];
                }
            }
            Program program = new Program();
            program.shuffleCards();
        }
       
    }
}
