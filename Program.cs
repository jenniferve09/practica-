using System; 

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        cuadrado figura1 = new cuadrado(10, 10, 10, 10, "cuadrado", "rosa");
        figura1.imprimir();
        

        rectangulo figura2 = new rectangulo(10, 20, "rectangulo", "azul");
        figura2.imprimir();
        
        

        circulo figura3 = new circulo(3.14, 4, "circulo", "very peri");
        figura3.imprimir();
        


        List<Interface> listaInterface1 = new List<Interface>();
        listaInterface1.Add(figura1);
        listaInterface1.Add(figura2);
        listaInterface1.Add(figura3);


        foreach (Interface item in listaInterface1)
        {
            item.calculo();
        }
    }
}

    
    