using System;
class HelloWorld {
  static void Main() {

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