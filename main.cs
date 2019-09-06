// Pablo Verduzco
// 9/3/2019
// This program will take an amount of cents, give back the amount of coins, and return the amount of money you get back after the small fee
using System;

class MainClass {
  public static void Main () 
  {
    int cents, numquarters, numdimes, numnickels, numpennies, afterquarters, afterdimes, afternickels;
    double totalchange, changeback;
    string strcents;
// Ask for cents and turn into integer.
    Console.WriteLine ("Please input the amount of cents you are inserting");
   
   strcents = Console.ReadLine();
   cents = int.Parse (strcents);
// all my math, using division to get amount of quarters, dimes, etc. and mod for change after you subtract the number of coins and money.
   numquarters = cents/25;
   afterquarters = cents%25;
   numdimes = afterquarters/10;
   afterdimes = afterquarters%10;
   numnickels = afterdimes/5;
   afternickels = afterdimes%5;
   numpennies = afternickels/5;
//State the amount of coins
   Console.WriteLine("You have");
   Console.WriteLine(numquarters + " quarters");
   Console.WriteLine(numdimes + " dimes");
   Console.WriteLine(numnickels + " nickels");
   Console.WriteLine(numpennies + " pennies");
// math for total change inputed and final amount you'll receive
   totalchange = cents/100.00;
   changeback = totalchange*.891;

   Console.WriteLine("Your total input was $" + totalchange);
   Console.WriteLine("You will receive ${0:0.00}", changeback);
  }
}