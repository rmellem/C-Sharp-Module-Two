/*
Rebecca Mellem
Intro to C#
Mod 2 Lab
Due: 8/29
*/
// Use comments to tell the WHY we coded that

#region TestingConditions

////======= Conditional Statements ==========
//// Booleans hold a True/False value
//bool isMorning = true;

//// if statement: evaluate a conditional expression to see if it is true
//// if it is true, it will run the next block of code (scope)
//// if it is false, it will skip the next block of code

//if (isMorning)
//{
//    Console.WriteLine("Good Morning");
//}

///* Comparison Operators
//> Greater Than
//>= Greater Than or Equal To
//< Less Than
//<= Less Than or Equal To
//== Equal To
//!= Not Equal To
//*/
//bool isTestOne = 6 > 5;

//if (isTestOne)
//{
//    Console.WriteLine("The result is " + isMorning);
//}

//bool isTestTwo = 5 != 5;
//// else will fire when the if is false

//if (isTestTwo)
//{
//    Console.WriteLine("The result is true");
//}
//else
//{
//    Console.WriteLine("The result is false");
//}

////else if (statement) will evaluate another condition and stop when it reaches the first true
//if (false)
//{
//    Console.WriteLine("The first condistion was true");
//}
//else if (true)
//{
//    Console.WriteLine("The second condition was true");
//}
//else if (true)
//{
//    Console.WriteLine("The third condition was true");
//}
//else
//{
//    Console.WriteLine("Everything else was false");
//}
////Switch is going to evaluate a value and see if it matches a case
//Console.Write("Enter a day of the week: ");
//string userAnswer = Console.ReadLine();

//switch (userAnswer)
//{
//    // case takes the value and sees if it is == to something
//    case "Monday":
//        Console.WriteLine("Mondays are bad");
//        break;
//    case "Tuesday":
//    case "Thursday":
//        Console.WriteLine("No C# Today");
//        break;
//    default:
//        break;
//}

////Logical Operators
//// && - Logical and - Returns True if both statements are true 
//// is a logical and with two operands
////  result in true if both operands (conditional expressions) are true

//// || is a logical or with two operands.
////  result in true if at least one operand is true.

//if (true && true)
//{
//    Console.WriteLine("The result is true");

//}


#endregion

/*
Input
- mL (milliliters) / data type (double)
- menu option / data type (int)

Processes
- convert mL to double
- convert menu option to int
- convert using a switch statement

Outputs
- output the result of the switch

 */

Console.Write("Enter amount in mL: ");
double userML = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("What do you want to convert to?");
Console.WriteLine("1. Teaspoons");
Console.WriteLine("2. Tablepoons");
Console.WriteLine("3. Cups");
Console.WriteLine("4. Quarts");
Console.WriteLine("Enter an integer: ");

int userChoice = Convert.ToInt32( Console.ReadLine() );
double convertedOutput = 0.0;

switch (userChoice)
{
    // if ( 1 == 1)
    case 1:
        convertedOutput = userML / 4.92;
        break;
    case 2:
        convertedOutput = userML / 14.8;
        break;
    case 3:
        convertedOutput = userML / 237;
        break;
    case 4:
        convertedOutput = userML / 946.4;
        break;
    default:
        Console.WriteLine("That is not a vailid choice");
        break;
}
// Math is all math and round is two arguements (data, place value)
Console.WriteLine("The conversion is " + Math.Round(convertedOutput, 1) );

// Patrick said we don't have to include the units