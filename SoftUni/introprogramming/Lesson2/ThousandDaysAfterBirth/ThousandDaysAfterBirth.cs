using System;
using System.Globalization;

class ThousandDaysAfterBirth
{
	public static void Main (string[] args)
	{
		DateTime birth = DateTime.ParseExact (Console.ReadLine (), "dd-MM-yyyy", CultureInfo.InvariantCulture);
		birth = birth.AddDays (999);
		string afterThousandDays = birth.ToString ("dd-MM-yyyy");
		Console.WriteLine (afterThousandDays);
	}
}

