using System;
class Programa {
  static void Main() {
    Circulo Obj = new Circulo();
    try {
      double Radio = double.Parse(Console.ReadLine());  
      Obj.CambiarRadio(Radio);
      Console.WriteLine("{0:F2}", Obj.ObtenerArea() );
    }
    catch(Exception err){
        //Console.WriteLine("Error en la radio indicado, intenta de nuevo");
        Console.WriteLine(err.Message);
    }
    
    
  }
}

class Circulo {
  private double Radio;
  public void CambiarRadio(double Radio){
     this.Radio = Radio;
  }
  public double ObtenerRadio (){
    return this.Radio;
  }
  public double ObtenerArea (){
     return Math.PI * Math.Pow(this.Radio, 2);
  }
}