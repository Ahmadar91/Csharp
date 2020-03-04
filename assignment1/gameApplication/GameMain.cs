using System;

namespace gameApplication
{
	class GameMain
	{
		static void Main(string[] args)
		{
			// create an object (instance) of pet class
			Game gameobj = new Game();
			// use the start method in the object class
			gameobj.Start();
			Console.WriteLine("press Enter to Exit!");
			Console.ReadLine();
		}
	}
}
