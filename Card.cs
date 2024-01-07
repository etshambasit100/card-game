public class Card
{
    public char Value { get; }
    public char Suit { get; }

    public Card(char value, char suit)
    {
        Value = value;
        Suit = suit;
    }
}