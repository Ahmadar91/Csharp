using System;

namespace PetApplication
{
	public class Pet
	{
		// name of the pet
		private string _name;
		// age of the pet in integer
		private int _age;
		// check if the pet is female or not
		private bool _isFemale;


		// Method that starts the object methods 
		public void Start() { 
			ReadAndSavePetData(); 
			DisplayPetInfo(); 
		}
		// methods display pet info after getting the input from user
		private void DisplayPetInfo()
		{
			string gender = "good boy!";
			if (_isFemale.Equals(true))
			{
				gender = "good girl!";
			}
			
			string str = "Name: " + _name + " age: " + _age;
			string str1 = _name + " is a " + gender;
			Console.WriteLine("---------------------------");
			Console.WriteLine(str);
			Console.WriteLine(str1);
			Console.WriteLine("----------------------------");
			Console.WriteLine();
		}
		// methods that gets the input from user
		private void ReadAndSavePetData()
		{
			ReadName();
			ReadAge();
			ReadGender();
		}
		// methods ask the user about gender of the pet and gets the user input
		private void ReadGender()
		{
			Console.WriteLine("Is your pet a female (y/n)? ");
			char response = char.Parse(Console.ReadLine().ToLower());
			if (response == 'y')
				_isFemale = true;
			else _isFemale = false;
		}
		// methods ask the user about age of the pet and gets the user input

		private void ReadAge()
		{
			Console.WriteLine("What is the age of " + _name);
			_age = int.Parse(Console.ReadLine());
		}
		// methods ask the user about name of the pet and gets the user input

		private void ReadName()
		{
			Console.WriteLine("Greetings from a Pet object!");
			Console.WriteLine("What is the name of your Pet?");
			_name = Console.ReadLine();
		}
	}
}
