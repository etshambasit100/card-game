using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        CardGame cardGame = new CardGame();

        Console.WriteLine("Enter a comma-separated list of cards:");
        string input = Console.ReadLine();

        try
        {
            List<Card> cards = ParseInput(input);
            cardGame.ValidateInput(cards);
            int score = cardGame.CalculateScore(cards);
            Console.WriteLine($"Score: {score}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static List<Card> ParseInput(string input)
    {
        var cards = new List<Card>();

        foreach (var cardString in input.Split(','))
        {
            if (cardString.Equals("JK", StringComparison.OrdinalIgnoreCase))
            {
                cards.Add(new Card('J', 'K'));  
            }
            else if (cardString.Length == 2)
            {
                char value = cardString[0];
                char suit = cardString[1];
                cards.Add(new Card(value, suit));
            }
            else
            {
                throw new ArgumentException("Invalid input string");
            }
        }

        return cards;
    }
}