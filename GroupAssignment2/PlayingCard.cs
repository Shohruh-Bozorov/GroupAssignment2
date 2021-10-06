using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}

		/// <summary>
		/// Returns "Face" for Ace,Knight, Queen, King. Otherwise it returns "Value".
		/// 
		/// </summary>
		string FaceOrValue

		{   //YOUR CODE
			//to return "Face" or "Value"
			//Use switch expression

			get
			{
				switch (Value)
				{

					case PlayingCardValue.Knight:
						break;
					case PlayingCardValue.Queen:
						break;
					case PlayingCardValue.King:
						break;
					case PlayingCardValue.Ace:
						break;
					default: return "Value";

				}
				return "Face";



				/*
				 // switch expression
				String FaceOrValue = Value switch
						{
					PlayingCardValue.Ace => FaceOrValue = "Face",
							PlayingCardValue.Knight => FaceOrValue = "Face",
							PlayingCardValue.Queen => FaceOrValue = "Face",
							PlayingCardValue.King => FaceOrValue = "Face",
							_ => FaceOrValue = "Value",
						};
					return FaceOrValue;

				*/
			}

		}
		public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} {FaceOrValue} card";

		/// <summary>
		/// Constructor that generates a random card
		/// </summary>
		public PlayingCard()
		{

			//YOUR CODE
			// write a constructor that generates a random card.
			// I.e., PlayingCard card1 = new PlayingCard(); generates a random card.

			//PlayingCard card1 = new PlayingCard();
			Random randCard = new Random();
			Color = (PlayingCardColor)randCard.Next(0, 4);
			Value = (PlayingCardValue)randCard.Next(1, 15);






		}

		public PlayingCard(PlayingCardColor color, PlayingCardValue value) 
		{

			Color = color;
			Value = value;

		}
	}
}
