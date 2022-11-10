using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    Stack <char> Pila = new Stack<char>();
    String Cadena;
    bool Error = false;
    char dato, car;
    int N;
    
    N = int.Parse(Console.ReadLine());
    
    for (int k=0; k<N ; k++){
    
    Cadena = Console.ReadLine();
    Pila.Clear();
    Error = false;
    for (int i=0; i < Cadena.Length && Error== false; i++){
        car = Cadena[i];
        if ( car=='(' || car=='[' || car == '{'   )
            Pila.Push(car);
        else {
            
          if (Pila.Count > 0){
              dato = Pila.Pop();
              switch (car){
                  case ')':
                        if (dato!='(')
                           Error = true;
                        break;
                  case ']':
                        if (dato!='[')
                            Error = true;
                        break;
                  case '}':
                        if (dato!='{')
                            Error = true;
                        break;
              }
          }  
          else
              Error = true;
        }
    }    
    if (Pila.Count == 0 && Error==false)
            Console.WriteLine("SI");
        else
            Console.WriteLine("NO");
   } // Cierra for k             
  } // Fin main
}