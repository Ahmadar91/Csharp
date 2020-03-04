using System;


namespace PetApplication
{
	class PetOwnerMain
	{
		static void Main(string[] args)
		{
			// create an object (instance) of pet class
			Pet petobj = new Pet();
			// use the start method in the object class
			petobj.Start();
			Console.WriteLine("press Enter to Exit!");
			Console.ReadLine();
		}
	}
}