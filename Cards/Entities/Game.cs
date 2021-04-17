using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cards.Entities
{
    public interface IGame
    {
        void PlayingCard();
        void ShufflingDeck();
        void RestartingGame();
    }

    public class Game : IGame
    {
        private List<Card> Cards { get; set; }
        private bool CardsStillLeft { get { return Cards.Count > 0; } }
        public Game()
        {
            RollCards();
        }
        private void RollCards()
        {
            Cards = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var cardName in Enum.GetNames(typeof(CardName)))
                {
                    Cards.Add(new Card() { Name = cardName, Suit = (CardSuit)suit });
                }
            }
            CardHelper.Shuffle(Cards);
        }
        public void PlayingCard()
        {
            if(CardsStillLeft)
            {
                var card = Cards.First();
                Console.WriteLine($"Card Played : {card.Name} of {card.Suit} ");
                Cards.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No cards left to play, please restart game");
            }
        }
        public void ShufflingDeck()
        {
            if (CardsStillLeft)
                CardHelper.Shuffle(Cards);
        }
        public void RestartingGame()
        {
            RollCards();
        }
    }
}
