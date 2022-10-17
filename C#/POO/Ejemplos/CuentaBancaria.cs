using System;
class HelloWorld {
  static void Main() {
    CuentaBancaria MiCuenta = new CuentaBancaria( );
    MiCuenta.Deposito(2000);
    MiCuenta.Retiro(500);
    decimal Saldo ;
    Saldo = MiCuenta.ObtenerSaldo();
    Console.WriteLine("El saldo del cliente es {0:C}", Saldo);
  }
}

class CuentaBancaria
{
  private decimal saldo;
  private string nombre;
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