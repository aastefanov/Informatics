using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class FruitOrVegetable
{
    public static void Main ( string[] args )
    {
        string vegetable = Console.ReadLine ();

        Dictionary<string, bool> vegetableDict = new Dictionary<string, bool> ();

        //Add vegetables
        {
            vegetableDict.Add ( "banana", false );
            vegetableDict.Add ( "apple", false );
            vegetableDict.Add ( "kiwi", false );
            vegetableDict.Add ( "cherry", false );
            vegetableDict.Add ( "lemon", false );
            vegetableDict.Add ( "grapes", false );

            vegetableDict.Add ( "tomato", true );
            vegetableDict.Add ( "cucumber", true );
            vegetableDict.Add ( "pepper", true );
            vegetableDict.Add ( "carrot", true );
        }

        string isVegetableString = isVegetable ( vegetableDict, vegetable );

        Console.WriteLine (isVegetableString);
    }

    public static string isVegetable(Dictionary<string,bool> dict, string key)
    {
        if (dict.ContainsKey(key))
        {
            return dict[key]?"vegetable":"fruit";
        }
        return "unknown";
    }
}
