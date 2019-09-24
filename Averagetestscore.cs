using System;

class MainClass {
  public static void Main () {
    int average, input, numinputs, a, total;
    string inputstr;
    average = 0;
    numinputs = 0;
    input = 0;
    total = 0;
    Console.WriteLine ("This program will give you your total average test scores");
    Console.WriteLine ("Please input all your test scores (in %). When you are done input -1");

    inputstr = Console.ReadLine ();
     input = int.Parse (inputstr);

    while (input !=-1) {
      a = input ;
     numinputs++;

     total = total + a;

     inputstr = Console.ReadLine ();
     input = int.Parse (inputstr);
    }
    average = total/numinputs;
    Console.WriteLine ("Your average test score is " + average + "%");

  }
}
