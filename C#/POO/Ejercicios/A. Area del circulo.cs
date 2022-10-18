using System;
class Programa {
  static void Main() {
    Circulo Obj = new Circulo();
    double Radio = double.Parse(Console.ReadLine());  
    Obj.CambiarRadio(Radio);
    Console.WriteLine("{0:F2}", Obj.ObtenerArea() );
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