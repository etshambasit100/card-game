using System;
using System.Collections.Generic;
using System.Linq;

public class CardGame
{
    public int CalculateScore(List<Card> cards)
    {
        int score = 0;
        int jokerMultiplier = 1;

        foreach (var card in cards)
        {
            if (card.Value == 'J')
            {
                jokerMultiplier *= 2;
            }
            else
            {
                int cardValue = GetCardValue(card.Value);
                int suitMultiplier = GetSuitMultiplier(card.Suit);

                score += cardValue * suitMultiplier;
            }
        }


        score *= jokerMultiplier;

        return score;
    }

    public void ValidateInput(List<Card> cards)
    {

        int jokerCount = 0;
        HashSet<string> uniqueCards = new HashSet<string>();

        foreach (var card in cards)
        {
            if (card.Value == 'J')
            {
                jokerCount++;
                if (jokerCount > 2)
                {
                    throw new ArgumentException("A hand cannot contain more than two Jokers.");
                }
            }
            else
            {
                string cardString = $"{card.Value}{card.Suit}";

                if (!IsValidCardValue(card.Value))
                {
                    throw new ArgumentException("Card not recognised");
                }

                if (!IsValidCardSuit(card.Suit))
                {
                    throw new ArgumentException($"Card suit '{card.Suit}' not recognised.");
                }

                if (!uniqueCards.Add(cardString))
                {
                    throw new ArgumentException("Cards cannot be duplicated");
                }
            }
        }
    }

    private int GetCardValue(char value)
    {
        switch (value)
        {
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                return int.Parse(value.ToString());
            case 'T':
                return 10;
            case 'J':
                return 11;
            case 'Q':
                return 12;
            case 'K':
                return 13;
            case 'A':
                return 14;
            default:
                throw new ArgumentException($"Card value '{value}' not recognised.");
        }
    }

    private int GetSuitMultiplier(char suit)
    {
        switch (suit)
        {
            case 'C':
                return 1;
            case 'D':
                return 2;
            case 'H':
                return 3;
            case 'S':
                return 4;
            default:
                throw new ArgumentException($"Card suit '{suit}' not recognised.");
        }
    }

    private bool IsValidCardValue(char value)
    {
        return "23456789TJQKA".Contains(value);
    }

    private bool IsValidCardSuit(char suit)
    {
        return "CDHS".Contains(suit);
    }
}
