using System;

class HungryGarfield
{
    public static void Main ( string[] args )
    {
        decimal money = decimal.Parse ( Console.ReadLine () );
        decimal usdRate = decimal.Parse ( Console.ReadLine () );
        decimal pizzaPrice = decimal.Parse ( Console.ReadLine () );
        decimal lasagnaPrice = decimal.Parse ( Console.ReadLine () );
        decimal sandwichPrice = decimal.Parse ( Console.ReadLine () );
        decimal pizzaQuantity = decimal.Parse ( Console.ReadLine () );
        decimal lasagnaQuantity = decimal.Parse ( Console.ReadLine () );
        decimal sandwichQuantity = decimal.Parse ( Console.ReadLine () );

        decimal allPizza = pizzaPrice * pizzaQuantity;
        decimal allLasagna = lasagnaPrice * lasagnaQuantity;
        decimal allSandwiches = sandwichPrice * sandwichQuantity;

        decimal moneyToPay = ( allPizza + allLasagna + allSandwiches ) / usdRate;


        string changeAsString = ( Math.Abs ( moneyToPay - money ) ).ToString ( "$0.00" );

        if ( moneyToPay < money )
        {
            Console.WriteLine ( "Garfield is well fed, John is awesome. Money left: {0}.", changeAsString );
        }
        else
        {
            Console.WriteLine ( "Garfield is hungry. John is a badass. Money needed: {0}.", changeAsString );
        }
    }
}
