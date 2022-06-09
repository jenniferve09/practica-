using System;
namespace ConsoleApp1;

public class rectangulo : figura, Interface
{
    public int Base { set; get; }
    public int altura { set; get; }
    public rectangulo (int Base, int altura,string nombre, string color) : base (nombre,color)
    {
        this.Base = Base;
        this.altura = altura; 

    }

    public void calculo()
    {
        int operaciones = 0;
        operaciones = Base * altura;
        Console.WriteLine("el area del"+nombre+ "es de:" + operaciones);
    }
}
