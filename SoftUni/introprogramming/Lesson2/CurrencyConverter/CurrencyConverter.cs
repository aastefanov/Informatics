using System;

class CurrencyConverter
{
	public static void Main ( string[] args )
	{
		decimal bgn = 1m;
		decimal usd = 1.79549m;
		decimal eur = 1.95583m;
		decimal gbp = 2.53405m;

		decimal moneyIn = decimal.Parse (Console.ReadLine ());
		decimal moneyThrough = 0m;
		decimal moneyOut = 0m;

		string currencyIn = Console.ReadLine ().ToUpper ();
		//string currencyThrough = "BGN";
		string currencyOut = Console.ReadLine ();

		switch (currencyIn)
		{
			case "BGN":
				moneyThrough = moneyIn * bgn;
				break;
			case "USD":
				moneyThrough = moneyIn * usd;
				break;
			case "EUR":
				moneyThrough = moneyIn * eur;
				break;
			case "GBP":
				moneyThrough = moneyIn * gbp;
				break;
			default:
				break;
		}

		switch (currencyOut)
		{
			case "BGN":
				moneyOut = moneyThrough / bgn;
				break;
			case "USD":
				moneyOut = moneyThrough / usd;
				break;
			case "EUR":
				moneyOut = moneyThrough / eur;
				break;
			case "GBP":
				moneyOut = moneyThrough / gbp;
				break;
			default:
				break;
		}

		Console.WriteLine (Math.Round (moneyOut, 2));
	}
}

