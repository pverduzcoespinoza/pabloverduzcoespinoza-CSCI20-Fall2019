//Pablo Verduzco
//10/10/19
// This program plays the game Pig with the user.
using System;

class MainClass {
  public static void Main (string[] args) {
    int dice, ans;
    string ans1;

    Console.WriteLine ("This is the game of Pig.");
    Console.WriteLine ("Each turn, a player repeatedly rolls a die until either a 1 is rolled or the player decides to hold.");
    Console.WriteLine ("If the player rolls a 1, they score nothing and it becomes the next player's turn.");
    Console.WriteLine ("If the player rolls any other number, it is added to their turn total and the player's turn continues.");
    Console.WriteLine ("If a player chooses to hold, their turn total is added to their score and it becomes the next player's turn.");
    Console.WriteLine ("The first player to score 50 or more points wins.");
    Console.Write ("Your first roll is ");
//creates a random number from 1 to 6
    Random rnd = new Random();
    dice = rnd.Next(1,7);
    Console.WriteLine (dice);
    //while loop that circles around until a player reaches 100
    while (int player1 <= 100 || int player2 <= 100) {
// while loop that asks player to keep rolling or
//stop rolling and add up points.
    while (dice > 1){
      player1 = dice + player1 ;
      Console.WriteLine ("Would you like to roll again? (If yes type 1, if not type 2");
      ans1 = Console.ReadLine ();
      ans = int.Parse (ans1);

      if (ans == 1){

        dice = rnd.Next(1,7);
        Console.WriteLine (dice);
      }
    }
}
}
}
