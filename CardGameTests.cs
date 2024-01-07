using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public class CardGameTests
{
    [TestMethod]
    public void ConvertListOfCardsToScore()
    {
        CardGame cardGame = new CardGame();
        Assert.AreEqual<int>(2, cardGame.CalculateScore(new List<Card> { new Card('2', 'C') }));
    }

    [TestMethod]
    public void Jokers()
    {
        CardGame cardGame = new CardGame();
        Assert.AreEqual<int>(0, cardGame.CalculateScore(new List<Card> { new Card('J', 'K') }));
    }

    [TestMethod]
    public void InvalidLists()
    {
        CardGame cardGame = new CardGame();
        Assert.ThrowsException<ArgumentException>(() => cardGame.CalculateScore(new List<Card> { new Card('1', 'S') }));
    }

    [TestMethod]
    public void DuplicatedCards()
    {
        CardGame cardGame = new CardGame();
        Assert.ThrowsException<ArgumentException>(() => cardGame.CalculateScore(new List<Card> { new Card('2', 'C'), new Card('2', 'C') }));
    }

    [TestMethod]
    public void ThreeOrMoreJokers()
    {
        CardGame cardGame = new CardGame();
        Assert.ThrowsException<ArgumentException>(() => cardGame.CalculateScore(new List<Card> { new Card('J', 'K'), new Card('J', 'K'), new Card('J', 'K') }));
    }

    [TestMethod]
    public void MultipleCards()
    {
        CardGame cardGame = new CardGame();
        Assert.AreEqual<int>(14, cardGame.CalculateScore(new List<Card> { new Card('A', 'C') }));
    }

    [TestMethod]
    public void MixOfNumberCards()
    {
        CardGame cardGame = new CardGame();
        Assert.AreEqual<int>(9, cardGame.CalculateScore(new List<Card> { new Card('2', 'C'), new Card('3', 'D'), new Card('4', 'H') }));
    }

    [TestMethod]
    public void MixOfFaceCards()
    {
        CardGame cardGame = new CardGame();
        Assert.AreEqual<int>(37, cardGame.CalculateScore(new List<Card> { new Card('J', 'C'), new Card('Q', 'D'), new Card('K', 'H') }));
    }

    [TestMethod]
    public void MixOfSuits()
    {
        CardGame cardGame = new CardGame();
        Assert.AreEqual<int>(36, cardGame.CalculateScore(new List<Card> { new Card('2', 'C'), new Card('3', 'D'), new Card('4', 'H'), new Card('5', 'S') }));
    }

   
}
