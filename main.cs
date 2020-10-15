using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("How many triangles would you like the hypotenuse of?");
    int totalmath = Convert.ToInt32(Console.ReadLine());
    for (int counter = 1; counter <= totalmath; counter++)
    {
      DetermineHypotenuse();
    }
  }

  public static void DetermineHypotenuse() {

    Console.WriteLine("What is the length of side one?");
    double side1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is the length of side two?");
    double side2 = Convert.ToDouble(Console.ReadLine());

    double Hypotenuse = Math.Sqrt((side1 * side1) + (side2*side2));

    Console.WriteLine("The hypotenuse of this triangle is " + Hypotenuse + "."); 
  }
}