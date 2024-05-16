public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Persona persona= new Persona("Diana", 24);
        persona.MostrarInformacion();
    }
}
class Persona {
    public string Nombre  { get; set; }
    public int Edad { get; set;}

    public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }


    public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
}



