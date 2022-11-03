using System;


class Estudiante {
    string Nombre;
    int Edad;
    int Grado;
    public Estudiante(string Nombre, int Edad, int Grado){
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Grado = Grado;
    }
    public string ObtenerNombre(){
        return Nombre;
    }
    public int ObtenerEdad(){
        return Edad;
    }
    public int ObtenerGrado(){
        return Grado;
    }
    
}



class Program {
    static void Main(string[] args) {

        Lista <Estudiante> Estudiantes = new Lista<Estudiante>(5);
        
        Estudiante est1 = new Estudiante("Hugo", 13, 2);
        Estudiante est2 = new Estudiante("Paco", 12, 3);
        Estudiante est3 = new Estudiante("Luis", 11, 1);
        
        Estudiantes.Agregar(est1);
        Estudiantes.Agregar(est2);
        Estudiantes.Agregar(est3);
        
        
        
        for (int i=0; i < Estudiantes.ULTIMO; i++){
            Estudiante est = Estudiantes.Obtener(i);
            Console.WriteLine("{0} {1} {2}",
                    est.ObtenerNombre(),
                    est.ObtenerEdad(),
                    est.ObtenerGrado()
                    );
        }
        
        
    }
    
}


class Lista <T> {
    T [] Datos;
    
    int Ultimo=0, Tam=0;
    
    public int TAM{
        get {
            return Tam;
        }
    }
    
    public int ULTIMO{
        get {
            return Ultimo;
        }
    }
    

    public Lista (int N){
        Datos = new T[N];
        Tam = N;
    }
   public int Buscar (T Dato){
        int Enc=-1;
        for (int i=0; i<Tam && Enc==-1 ;i++ ){
            if (Dato.Equals(Datos[i])){
                Enc = i;
            }
        }
        return Enc;
    }
    public bool Agregar (T Dato){
        bool Estado = false;
        if (Ultimo < Tam){
            Datos[Ultimo]=Dato;
            Ultimo++;
            Estado = true;
        }
        return Estado;
    }
    public T Obtener  (int Pos){
        return Datos[Pos];    
    }
}


