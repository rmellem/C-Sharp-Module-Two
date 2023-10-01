//Restaurant & Dietary Restriction Availablity 
/*
Input
- Restaurant Name / data type (string)
    - Thunder Bay Grill
    - Marco's Pizza 
    - Cafe Manna
    - India  Kitchen
    - Harvest Cafe
- Vegetarian? / data type (string)
    - Thunder Bay Grill 
        -No / data type (bool)
    - Marco's Pizza 
        -Yes 
    - Cafe Manna
        -Yes 
    - India  Kitchen
        -Yes
    - Harvest Cafe
        -Yes
- Vegan? / data type (string)
    - Thunder Bay Grill
        -No / data type (bool)
    - Marco's Pizza 
        -No
    - Cafe Manna
        -Yes
    - India  Kitchen
        -No
    - Harvest Cafe
        -Yes
- Gluten Free? / data type (string)
    - Thunder Bay Grill
        -No / data type (bool)
    - Marco's Pizza 
        -Yes 
    - Cafe Manna
        -Yes
    - India  Kitchen
        -No
    - Harvest Cafe
        -Yes
*/


using System;
using System.Xml.Linq;
// ask for user input y/n
Console.Write("Is anyone attending the party a vegetarian? (y/n) ");
string vegetarian = Console.ReadLine();
// ask for user input y/n
Console.Write("Is anyone attending the party a vegan? (y/n) ");
string vegan = Console.ReadLine();
// ask for user input y/n
Console.Write("Is anyone attending the party gluten free? (y/n) ");
string glutenFree = Console.ReadLine();
// provide the available restraunts based on vegetarian/vegan/gluten free restrictions
Console.WriteLine("You may order from the following restraunts: ");
// not vegetarian - see vegetarian below method
if (vegetarian == "n")
{
    // not vegan - see vegan below in the vegetarian "n"
    if (vegan == "n")
    {
        // not gluten free - see gluten free below in the vegetarian "n"
        //will deliver below for (n/n/n)
        if (glutenFree == "n")
        {
            Console.WriteLine("Thunder Bay Grill");
            Console.WriteLine("Marco's Pizza");
            Console.WriteLine("Cafe Manna");
            Console.WriteLine("India Kitchen");
            Console.WriteLine("Harvest Cafe");
        }
        // gluten free - "y" will deliver below for (n/n/y)
        else if (glutenFree == "y")
        {
            Console.WriteLine("Marco's Pizza");
            Console.WriteLine("Cafe Manna");
            Console.WriteLine("Harvest Cafe");
        }
        //display if anything other than y/n is used
        else
        {
            Console.WriteLine("Not a valid response");
        }
    }
    // vegan - vegan "y" within the - not vegetarian method
    else if (vegan == "y")
    {
        // not gluten free - 2 options will deliver below for (y/n/n)
        if (glutenFree == "n")
        {
            Console.WriteLine("Cafe Manna");
            Console.WriteLine("Harvest Cafe");
        }
        //gluten free - "y" will deliver below for (y/n/y)
        else if (glutenFree == "y")
        {
            Console.WriteLine("Cafe Manna");
            Console.WriteLine("Harvest Cafe");
        }
        //display if anything other than y/n is used
        else
        {
            Console.WriteLine("Not a valid response");
        }
    }
    //display if anything other than y/n is used
    else
    {
        Console.WriteLine("Not a valid response");
    }
}
//block of code to run if user states "y" to vegetarian - outside original "n" scope 
else if (vegetarian == "y")
{
    // (y - vegetarian code) && not vegan
    if (vegan == "n")
    {
        Console.WriteLine("Marco's Pizza");
        Console.WriteLine("Cafe Manna");
        Console.WriteLine("Harvest Cafe");

        // restraunts are the same availablity if someone is gluten free && vegetarian but not vegan
        // need to add India Kitchen as an available option if no gluten free restrictions
        if (glutenFree == "n")
        {
            Console.WriteLine("India Kitchen");
        }
    }
    // (y - vegetarian code) && vegan selections
    else if (vegan == "y")
    {
        //gluten free - "n" will deliver below for (y/y/n)
        if (glutenFree == "n")
        {
            Console.WriteLine("Cafe Manna");
            Console.WriteLine("Harvest Cafe");
        }
        //gluten free - "y" will deliver below for (y/y/y)
        else if (glutenFree == "y")
        {
            Console.WriteLine("Cafe Manna");
            Console.WriteLine("Harvest Cafe");
        }
        //display if anything other than y/n is used
        else
        {
            Console.WriteLine("Not a valid response");
        }
    }
    //display if anything other than y/n is used
    else
    {
        Console.WriteLine("Not a valid response");
    }
}
//display if anything other than y/n is used
else
{
    Console.WriteLine("Not a valid response");
}








