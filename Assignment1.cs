// Pablo Verduzco
// 9/10/19
// This program will take the average amount of slices that each person will eat, slices per pizza, and the price of each pizza and will tell you how many pizzas you should buy, the total price, and how much each person will pay.

using System;
class MainClass {
  public static void Main ()
   {
     //Declaration of the variables
     double numberofpeople, slicesperperson, slicesperpizza, totalslices;
     string strslicesperperson, strslicesperpizza, strpriceperpizza, strnumberofpeople;
     double numpizzasone,numpizzas, priceperpizza, totalprice, priceperperson;
     //Welcome message and ask for numbers needed for math
    Console.WriteLine ("Welcome to Pizza price calculator!");

    Console.WriteLine ("Please input the number of people eating pizza");
    strnumberofpeople = Console.ReadLine ();
    numberofpeople= double.Parse (strnumberofpeople);

    Console.WriteLine ("Input the average amount of slices per person.");
    strslicesperperson = Console.ReadLine ();
    slicesperperson = double.Parse (strslicesperperson);

    Console.WriteLine ("Input the slices per pizza");
    strslicesperpizza = Console.ReadLine ();
    slicesperpizza = double.Parse (strslicesperpizza);

    Console.WriteLine ("Input the price per pizza (in dollars)");
    strpriceperpizza = Console.ReadLine();
    priceperpizza = double.Parse (strpriceperpizza);
    //Math needed to get the number of pizzas, total price and price per person.
    totalslices = slicesperperson * numberofpeople;
    numpizzasone = totalslices/slicesperpizza;
    numpizzas = Math.Ceiling(numpizzasone);
    totalprice = priceperpizza * numpizzas;
    priceperperson = totalprice/numberofpeople;
    //Display results
    Console.WriteLine ("You should buy " + numpizzas +" pizzas.");
    Console.WriteLine ("The total price will be $" + totalprice + ".");
    Console.WriteLine ("Each person will pay $" + priceperperson + ".");
  }
}
