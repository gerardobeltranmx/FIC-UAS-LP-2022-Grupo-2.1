using System;
class Programa {
  static void Main() {
      Circulo Llanta = new Circulo();
      Llanta.Radio = 10;
      Console.WriteLine("Para un radio de {0} tendremos una area de {1}",
                        Llanta.Radio,
                        Llanta.Area
                       ); 
    
  }
}

class Circulo {
       private double radio;
        // Propiedad Radio
        public double Radio
        {
            set {
                if (value > 0)
                    radio = value;
                else
                   radio = 0;
            }
            get {
                return radio;
            }
        }
        // Propiedad Area
        public double Area
        {
            get {
                return ObtenerArea();
            }
        }
        private double ObtenerArea(){
          return Math.PI * Math.Pow(radio,2);
        }
}
