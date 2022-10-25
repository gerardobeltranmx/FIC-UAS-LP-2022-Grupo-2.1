using System;
class Programa {
  static void Main() {
    int []datos = {1,2,5,3,8};
    try {
    	Console.WriteLine("Indica el indice : ");
    	int i = int.Parse(Console.ReadLine());
      Console.WriteLine(datos[i]);
    }
    catch (Exception error)
    {
    	Console.WriteLine(error.Message);
    }
}
}

