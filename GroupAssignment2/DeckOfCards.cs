using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;
        
        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => cards.Length;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < Count; i++)
            {

                sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            
            int randomCard1;
            int randomCard2;
            
            PlayingCard[] shuffleCards = new PlayingCard[MaxNrOfCards];

            //PlayingCard card;
            for (int i = 0; i < 1000; i++)
            {
                var rnd = new Random(); //rnd is now a random generator - see .NET documentation

                /*
                                    card1 = rnd.Next(0, 52);
                                    card2 = rnd.Next(0, 52);
                                    card = cards[card1];
                                    cards[card1] = cards[card2];
                                    cards[card2] = card;
                 */

                randomCard1 = rnd.Next(0, cards.Length);
                randomCard2 = rnd.Next(0, cards.Length);
                shuffleCards[randomCard1] = cards[randomCard1];
                cards[randomCard1] = cards[randomCard2];

                cards[randomCard2] = shuffleCards[randomCard1];
                
            }

            //YOUR CODE
            //to shuffle the deck.
            //Hint: pick two cards in the deck randomly and swap them. Do this 1000 times
        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        /// 
        public void FreshDeck()
        {   
            //YOUR CODE
            //to initialize a fresh deck of cards
            int cardNr = 0;
            
            for (int v = 2; v < 15; v++)
            {
                for (int c = 0; c < 4; c++)
                {
                    cards[cardNr] = new PlayingCard((PlayingCardColor)c, (PlayingCardValue)v);
                    cardNr++;
                }
            }

            /*
            for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++)
            {
                for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++)
                {
  
                    //Alternative way working for PlayingCard being both class and struct
                    cards[cardNr] = new PlayingCard { Color = color, Value = value };

                    //new PlayingCard((PlayingCardColor), color(PlayingCardValue), value );

                    //Prepare to initialize next card
                    cardNr++;
                }
            }

            */


        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards ()
        {
            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards
        }
    }
}
