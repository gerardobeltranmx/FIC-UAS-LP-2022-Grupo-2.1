using System;
class Programa {
  static void Main() {
    
    figura fig; 
     string [] datos = Console.ReadLine().Split(" ");
    int Lado1 = int.Parse(datos[0]) ;
    int Lado2 = int.Parse(datos[1]) ;
    
    fig = new rectangulo(Lado1, Lado2);

    Console.WriteLine(Fig.Area());
    
  }
  
  class figura
{
    public virtual Double Area( )  
    { 
	return 0;
    }
    public virtual Double Perimetro( ) 
    { 
	return 0;
    } 
}

class cuadrado : figura {
        double lado;

        public cuadrado(double lado) {
            this.lado = lado;
        }
        public override double Area(){
            return lado * lado;
        }
        public override double Perimetro()
        {
            return 4 * lado;
        }
 }
class circulo : figura{
        double radio;

        public circulo(double radio)
        {
            this.radio = radio;
        }
        public override double Area ()
        {
            return 3.1416*radio*radio;
        }
        public override double Perimetro()
        {
            return 2*3.1416*radio ;
        }
class rectangulo : figura{
    double lado1, lado2;

        public rectangulo(double lado1, double lado2) {
            this.lado1 = lado1;
            this.lado2 = lado2;
            
        }
        public override double Area(){
            return lado1 * lado2;
        }
        public override double Perimetro()
        {
            return 2 * lado1 + 2 * lado2;
        }
    
}

  class triangulo : figura{
    double Base, altura;

        public triangulo(double Base, double altura) {
            this.Base = Base;
            this.altura = altura;
            
        }
        public override double Area(){
            return Base * Altura;
        }
        public override double Perimetro()
        {
            return  0; //2 * lado1 + 2 * lado2;
        }
    
}

    
    
}