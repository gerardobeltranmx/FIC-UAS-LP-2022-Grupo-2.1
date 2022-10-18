using System;
class Programa {
  static void Main() {
      ConvertTemp Clima = new ConvertTemp();

      int Temp = int.Parse(Console.ReadLine());

      Clima.CambiarTemp(Temp);

      Console.WriteLine("{0} {1} {2}", 
                        Clima.GradosKelvin(),
                        Clima.GradosFahrenheit(),
                        Clima.GradosRéaumur()
                       );
    
  }
}


class ConvertTemp {
  private int GradosCelcius;

  public ConvertTemp(){
    
  }
  public ConvertTemp(int Temp){
    this.GradosCelcius = Temp;
  }
  
  
  public void CambiarTemp(int Temp){
      this.GradosCelcius = Temp;
  }
  public int ObtenerTemp (){
    return GradosCelcius;
  }
  public int GradosKelvin (){
    return GradosCelcius + 273;
  }
  public int GradosFahrenheit (){
    return 9 / 5 * GradosCelcius + 32;
  }
   public int GradosRéaumur (){
    return 4 * GradosCelcius / 5  ;
  }
  
  
}