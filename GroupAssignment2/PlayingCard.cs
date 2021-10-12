using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Fredrik, Niklas Shohruh

namespace GroupAssignment2
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace               // Poker Value order
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
				// switch expression
				string faceOrValue = Value switch
				{
					PlayingCardValue.Ace => faceOrValue = "Face",
					PlayingCardValue.Knight => faceOrValue = "Face",
					PlayingCardValue.Queen => faceOrValue = "Face",
					PlayingCardValue.King => faceOrValue = "Face",
					_ => faceOrValue = "Value",
				};

				return faceOrValue;

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
			// I.e., PlayingCard card1 = new PlayingCard(); generates a random card

			Random randNr = new Random();
			Color = (PlayingCardColor)randNr.Next(0, 4);
			Value = (PlayingCardValue)randNr.Next(1, 15);


		}

		public PlayingCard(PlayingCardColor color, PlayingCardValue value) 
		{

			Color = color;
			Value = value;

		}
	}
}
