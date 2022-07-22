// See https://aka.ms/new-console-template for more information
int selectionFromUser = 0;
Console.WriteLine("Welcome to the C#\n Lets go through the Menu\n 1. Press 1 for finding length of String \n Press 2 for Finding number of Characters \n Press 3 to exit");
selectionFromUser = Int32.Parse( Console.ReadLine());
switch (selectionFromUser)
{
    case 1:
        string stringInputFromUser = "";
        Console.WriteLine("Enter String to get Length\n");
        stringInputFromUser = Console.ReadLine();
        int lengthOfString = stringInputFromUser.Length;
        Console.WriteLine("The string Entered is " + stringInputFromUser);
        Console.WriteLine("The Length of String is " + lengthOfString);
        break;
    case 2:
        break;
    case 3:
        break;
    default:
        Console.WriteLine("Please Choose Correct Option");
            break;


}