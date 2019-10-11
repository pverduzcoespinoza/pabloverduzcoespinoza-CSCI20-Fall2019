//Pablo Verduzco
//9/24/19
//This program takes the user input of hours and writes "Are we there yet" that many times.
using System;

class MainClass {
  public static void Main () {
    int hours;
    string hoursstr;

    Console.WriteLine ("You are in a long roadtrip with your kid");
    Console.WriteLine ("How many hours long is the trip?");

    hoursstr = Console.ReadLine ();
    hours = int.Parse (hoursstr);

    //this loop writes out "Are we there yet" then subtracts the 1 from the hours.
    while (hours>0) { //repeats until hours is 0
      Console.WriteLine ("Are we there yet");
      hours--;
    }
  }
}
