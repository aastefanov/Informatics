using System;

class GreetingByName
{
	public static void Main ( string[] args )
	{
		//Console.Write ("Enter your name: ");
		string name = Console.ReadLine ();
		Console.WriteLine ("Hello, {0}!", name);
	}
}
