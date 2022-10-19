using System;
class Programa {
  static void Main() {
    
    Cilindro Tanque = new Cilindro(20, 100);
    Console.WriteLine ("Superficie={0:F2} Volumen={1:F2}",
              Tanque.ObtenerSuperficie(),
              Tanque.ObtenerVolumen()
          );
    

  }
}
class Circulo{
  private double radio;
  public Circulo(double r){
    radio=r;
  }
  public void CambiarRadio(double r){
    radio=r;
  }
  public double ObtenerRadio(){
    return radio;
  }
  public double ObtenerArea(){
    return 3.1416*radio*radio;
  }
  public double ObtenerPerimetro(){
    return 3.1416*2*radio;
  }
}

class Cilindro:Circulo{
  private double altura;
   public Cilindro(double r, double h): base(r){
   altura=h;
  }
 public void CambiarAltura(double h){
   altura=h;
 }
 public double ObtenerAltura(){
   return altura;
 }
  public double ObtenerVolumen(){
   return ObtenerArea()*ObtenerAltura();
  }
  public double ObtenerSuperficie(){
    return 2 * ObtenerArea() + ObtenerPerimetro() * ObtenerAltura() ;
  }
}