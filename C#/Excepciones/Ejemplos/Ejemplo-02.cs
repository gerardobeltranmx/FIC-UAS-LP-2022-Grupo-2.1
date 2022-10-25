using System;
class Programa {
  static void Main() {
    int x=4,y=0,z;
    try { 
	      z = x / y; 
        Console.WriteLine(z);
    } 
    catch ( DivideByZeroException Err) { 	
      //Console.WriteLine("División por cero!!!"); 
        Console.WriteLine (Err.Message);
    } 
  }
}