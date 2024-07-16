using System;

class Program {
  public static void Main (string[] args) {

    //displays the Greenville motto
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************");
    Console.WriteLine();

    //displays the menu options
    Console.WriteLine("Plese enter a number according to the menu:");
    Console.WriteLine();
    Console.WriteLine("1. Calculate Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");

    int menuSelection = IsInputNumber.GetInt(Console.ReadLine()) ?? 0;
    while(menuSelection != 1 && menuSelection != 2)
    {
      Console.Write("Please enter a valid number: ");
      menuSelection = IsInputNumber.GetInt(Console.ReadLine()) ?? 0;
    }

    //each of the menu options
    switch(menuSelection)
    {
    case 1:
      /*calculates expected revenue at $25 per person
      and prints whether or not this year has more people*/ 
      Console.WriteLine();
      Console.Write("Please enter the number of contestants in the previous year: ");
      int? previousYear = IsInputNumber.GetInt(Console.ReadLine());

      //loop until a valid number is entered for the previous year
      while(previousYear == null || previousYear < 0 || previousYear > 30)
      {
        Console.Write("Please enter a number 0-30: ");
        previousYear = IsInputNumber.GetInt(Console.ReadLine());
      }

      Console.Write("Please enter the number of contestants in this year: ");
      int? currentYear = IsInputNumber.GetInt(Console.ReadLine());

      //loop until a valid number is entered for the current year
      while(currentYear == null || currentYear < 0 || currentYear > 30)
      {
        Console.Write("Please enter a valid number 0-30: ");
        currentYear = IsInputNumber.GetInt(Console.ReadLine());
      }

      Console.WriteLine();
      Console.WriteLine("Revenue expected this year: ${0}", currentYear * 25);

      /*prints whether or not this year has more, less, or the same
      number of people*/
      if(currentYear > previousYear * 2)
      Console.WriteLine("The competition is more than twice as big this year!");
      else if(currentYear > previousYear)
        Console.WriteLine("The competition is bigger than ever!");
      else if(currentYear < previousYear)
        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
      else
      Console.WriteLine("This year's competition is the same than last year's.");
      break;

    //ends when 2 (exit) is entered and prints a goodbye message
    case 2:
      Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
      break;

    default:
      break;
    }
  }
}