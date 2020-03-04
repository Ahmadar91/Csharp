using System;


namespace gameApplication
{
	public class Game
	{
		// title of the pet
		private string _title;
		// price of the pet in integer
		private int _price;
		// type of the console that the game runs on
		private string _type;

		// Method that starts the object methods 
		internal void Start()
		{
			ReadAndSaveGameData();
			DisplayGameInfo();
		}
		// methods display pet info after getting the input from user
		private void DisplayGameInfo()
		{
			string str = "Title: " + _title + " price: " + _price + " SEK";
			string str1 = "game can run on " + _type;
			Console.WriteLine("---------------------------");
			Console.WriteLine(str);
			Console.WriteLine(str1);
			Console.WriteLine("----------------------------");
			Console.WriteLine();
		}
		// methods that gets the input from user
		private void ReadAndSaveGameData()
		{
			ReadTitle();
			ReadPrice();
			ReadType();
		}
		// methods ask the user about type of the game and gets the user input
		private void ReadType()
		{
			Console.WriteLine("on which console does " + _title + " run on?");
			Console.WriteLine("1- PlayStation4");
			Console.WriteLine("2- Xbox one");
			Console.WriteLine("3- PC");
			Console.WriteLine("insert 1,2 or 3 to choose the console");
			string input = Console.ReadLine();

			switch (input)
			{
				case "1":
					_type = "Playstation 4";
					break;
				case "2":
					_type = "Xbox one";
					break;
				case "3":
					_type = "PC";
					break;
				default:
					Console.WriteLine("Incorrect value!");
					break;
			}
		}
		// methods ask the user about price of the game and gets the user input
		private void ReadPrice()
		{
			Console.WriteLine("What is the price of " + _title + " in SEK?");
			string input = Console.ReadLine();
			_price = int.Parse(input);
		}
		// methods ask the user about title of the game and gets the user input
		private void ReadTitle()
		{
			Console.WriteLine("Greetings from a Game object!");
			Console.WriteLine("What is the title of your Game?");
			_title = Console.ReadLine();
		}
	}
}