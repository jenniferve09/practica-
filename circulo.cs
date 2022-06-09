using System;
namespace ConsoleApp1;

public class circulo : figura, Interface
{
    public double Pi = 3.14; 
    public double radio { set; get;  }
    public circulo(double Pi, double radio, string nombre, string color): base(nombre, color)
    {
        this.radio = radio;
        
    }

    public void calculo ()
    {
        double operaciones=0;
        operaciones = Pi*(radio * radio);
        Console.WriteLine("el area del"+nombre+ "es de:" + operaciones); 
    }
}
 