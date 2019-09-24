using System;

class MainClass {
  public static void Main () {
    int a;
    string at;

    Console.WriteLine ("You are in a long roadtrip with your kid");
    Console.WriteLine ("How many hours long is the trip?");

    at = Console.ReadLine ();
    a = int.Parse (at);
    while (a>0) {
      Console.WriteLine ("Are we there yet");
      a--;
    }
  }
}
