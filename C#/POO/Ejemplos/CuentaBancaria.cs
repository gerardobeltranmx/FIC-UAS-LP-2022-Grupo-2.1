using System;
class HelloWorld {
  static void Main() {
    CuentaBancaria MiCuenta = new CuentaBancaria( );
    CuentaBancaria OtraCuenta = new CuentaBancaria();
    MiCuenta.CambiarNombre("Luis Lopez");
    MiCuenta.Deposito(2000);
    MiCuenta.Retiro(500);
    
    OtraCuenta.Deposito(1234);
    decimal Saldo ;
    Saldo = MiCuenta.ObtenerSaldo();
    Console.WriteLine("El saldo del cliente {0} es {1:C}", 
                      MiCuenta.ObtenerNombre(),
                      Saldo);
     Console.WriteLine("El saldo de otro cliente es {0:C}",       
                OtraCuenta.ObtenerSaldo());
 
  }
}

class CuentaBancaria
{
  private decimal saldo;
  private string nombre;
  public string ObtenerNombre(){
    return nombre;
  }
  public void CambiarNombre(string nombre){
    this.nombre = nombre;
  }
  public void Retiro(decimal cantidad){
    saldo-=cantidad;
  }
  public void Deposito(decimal cantidad){
    saldo+=cantidad;
  }
  public decimal ObtenerSaldo( ){
    return saldo;
  }
}