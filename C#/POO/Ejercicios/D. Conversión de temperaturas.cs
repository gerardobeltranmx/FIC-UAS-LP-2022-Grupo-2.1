using System;
class Programa {
  static void Main() {

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
  public GradosKelvin (){
    return GradosCelcius + 273;
  }
  public GradosFahrenheit (){
    return 9 / 5 * GradosCelcius + 32;
  }
   public GradosRéaumur (){
    return 4 * GradosCelcius / 5  ;
  }
  
  
}