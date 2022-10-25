using System;
class HelloWorld {
  static void Main() {
    
    
    int i, dato;
    Console.Write("Escriba un numero: ");
    try {
        i = int.Parse(Console.ReadLine());
        Console.WriteLine(i);
        dato = 100 / i;
        Console.WriteLine(dato);
        
    }
    catch(FormatException){
        // Console.WriteLine("Error: " + Error.Message);
        Console.WriteLine("Error: Solo se permiten numeros");
    }
    catch (OverflowException){
        // Console.WriteLine("Error: " + Error.Message);
        Console.WriteLine("Error: Numero muy grande");
        Console.WriteLine("Error: Tus limite son de {0} hasta {1}",
            Int32.MinValue,
            Int32.MaxValue
        );
    }
    catch (DivideByZeroException ){
        Console.WriteLine ("Se presento una división por cero (0)");
    }
    catch (Exception Error){
       // Console.WriteLine("Error: " + Error.Message);
       Console.WriteLine("Error no controlado, consulta con el Administrador");
    }
  }
}