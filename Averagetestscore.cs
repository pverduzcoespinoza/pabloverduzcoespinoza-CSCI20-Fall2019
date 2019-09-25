//Pablo Verduzco
//9/24/19
//This Program will take all the inputs from the user and output the average test score.
using System;

class MainClass {
  public static void Main () {
    //declaration of variables
    int average, input, numinputs, total;
    string inputstr;
    //Set variables to 0 outside the loop
    average = 0;
    numinputs = 0;
    input = 0;
    total = 0;

    Console.WriteLine ("This program will give you your total average test scores");
    Console.WriteLine ("Please input all your test scores (in %). When you are done input -1");

//Reads the first input from the user, cant be inside yet or it will read and add -1
    inputstr = Console.ReadLine ();
     input = int.Parse (inputstr);
//while loop to make it possible to keep adding inputs.
    while (input !=-1) {
     numinputs++; //adds one to the number of inputs.

     total = total + input; // creates new total
//reads new input
     inputstr = Console.ReadLine ();
     input = int.Parse (inputstr);
   }//(repeat)
    average = total/numinputs; //finds average
    Console.WriteLine ("Your average test score is " + average + "%");

  }
}
