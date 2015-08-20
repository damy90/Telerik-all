using NUnit.Framework;
using Santase.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase.Logic.Cards.Tests
{
    [TestFixture()]
    public class DeckTests
    {
        private static int cardsCount = 24;

        [Test()]
        public void NewDeckTestCardCountShouldBe24()
        {
            var deck = new Deck();
            Assert.AreEqual(deck.CardsLeft, cardsCount, "The new deck must have " + cardsCount + " cards");
        }

        [Test()]
        public void DeckTestGetValidTrumpCard()
        {
            var deck = new Deck();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), deck.GetTrumpCard.Suit), "Invalid card suit: " + deck.GetTrumpCard.Suit.ToString());
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), deck.GetTrumpCard.Type), "Invalid card type: " + deck.GetTrumpCard.Type.ToString());
        }

        [Test()]
        public void DeckTestGetNextCardShouldReturnValidCard()
        {
            var deck = new Deck();
            var card = deck.GetNextCard();
            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), card.Suit), "Invalid card suit: " + deck.GetTrumpCard.Suit.ToString());
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), card.Type), "Invalid card type: " + deck.GetTrumpCard.Type.ToString());
        }

        [Test()]
        public void DeckTestGetNextCard24TimesShouldReturn24ValidCards()
        {
            var deck = new Deck();
            for (int i = 0; i < cardsCount; i++)
            {
                var card = deck.GetNextCard();
                Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), card.Suit), "Invalid card suit: " + deck.GetTrumpCard.Suit.ToString() + "in position " + (i + 1));
                Assert.IsTrue(Enum.IsDefined(typeof(CardType), card.Type), "Invalid card type: " + deck.GetTrumpCard.Type.ToString() + "in position " + (i + 1));
            }

            Assert.AreEqual(deck.CardsLeft, 0, "There should be 0 cards left in the deck!");
        }

        [TestCase(1)]
        [TestCase(12)]
        [TestCase(24)]
        public void DeckTestGetNextCardValidNumberOfTimesShouldReturnValidCard(int getCardCount)
        {
            var deck = new Deck();
            Card card = null;
            for (int i = 0; i < getCardCount; i++)
            {
                card = deck.GetNextCard();
            }

            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), card.Suit), "Invalid card suit: " + deck.GetTrumpCard.Suit.ToString() + "in position " + getCardCount);
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), card.Type), "Invalid card type: " + deck.GetTrumpCard.Type.ToString() + "in position " + getCardCount);
        }

        [Test()]
        [ExpectedException(typeof(InternalGameException))]
        public void DeckTestGetNextCard25TimesShouldThrow()
        {
            var deck = new Deck();
            for (int i = 0; i < cardsCount + 1; i++)
            {
                var card = deck.GetNextCard();
            }
        }


        [Test()]
        public void ChangeTrumpCardTestShouldChangeTheTrumpCard()
        {
            Deck testDeck = new Deck();
            Card initialTrumpCard = testDeck.GetTrumpCard;
            Card newCard = testDeck.GetNextCard();
            testDeck.ChangeTrumpCard(newCard);
            Assert.AreNotSame(initialTrumpCard, testDeck.GetTrumpCard);
        }

        [Test()]
        public void ChangeTrumpCardTestShouldNotChangeTheTrumpCardIfNoCardsLeftInDeck()
        {
            Deck testDeck = new Deck();
            Card initialTrumpCard = testDeck.GetTrumpCard;
            Card newCard = new Card(CardSuit.Spade, CardType.Ace);
            for (int i = 0; i < cardsCount; i++)
            {
                if (i == cardsCount - 1)
                {
                    newCard = testDeck.GetNextCard();
                }
                else
                {
                    testDeck.GetNextCard();
                }
            }

            testDeck.ChangeTrumpCard(newCard);
            
            Assert.AreSame(initialTrumpCard, testDeck.GetTrumpCard, "ChangeTrumpCard should not change the trump card when there are no cards left in the deck");
        }
    }
}