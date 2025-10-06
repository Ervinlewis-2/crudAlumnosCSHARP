using Herencia.Models;

class Program
    {
    static void Main(string[] args)
    {
        // Crear una instancia de la clase derivada
        Alumno alumno = new Alumno();
        // Llamar a métodos de la clase base y derivada
        alumno.Nombre = "Juan Pérez";
        alumno.AEmail = "ervin@gmail.com";
        alumno.Nota = 95;
        alumno.Mostrar();

        Profesor profesor = new Profesor();
        profesor.Nombre = "María Gómez";
        profesor.AEmail = "juan@gmail.com";
        profesor.Mostrar();
    }
}