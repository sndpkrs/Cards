using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cards
{
    public static class CardHelper
    {
        public static bool ValidateInput(string inputString)
        {
            var validInput = new[] { "1", "2", "3", "4" };
            return validInput.Contains(inputString);
        }

        // This shuffle method itself is taken from stack overflow, although I understand the logic that is being used here
        public static void Shuffle<T>(IList<T> cards)
        {
            Random rnd = new Random();
            for (int count = cards.Count; count > 1;)
            {
                int randomNumberUnderCount = rnd.Next(count);
                --count;
                T temp = cards[count];
                cards[count] = cards[randomNumberUnderCount];
                cards[randomNumberUnderCount] = temp;
            }
        }
    }
}
