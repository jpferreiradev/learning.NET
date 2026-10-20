Console.WriteLine("### Campos estáticos ### \n");


//A a1 = new A();
//a1.x = 10;

//A a2 = new A();
//a2.x = 20;

//// campo estatico
//A.y  = 30; // Ele não pertecem a instancia da classe, e sim a CLASSE; 

//Console.WriteLine($"a1.x = {a1.x} a2.x = {a2.x} A.y= {A.y}");


ExercicioCamposEstaticos.Executar();



Console.ReadKey();

public class A
{
    public int x; // campo de estancia
    public static int y; // campo estático

}