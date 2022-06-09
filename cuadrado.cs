using System;
namespace ConsoleApp1;
public class cuadrado:figura, Interface
{
    public int lado1 { set; get; }
    public int lado2 { set; get; }
    public int lado3 { set; get; }
    public int lado4 { set; get; }
    public cuadrado (int lado1,int lado2, int lado3, int lado4, string nombre, string color): base(nombre, color)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
        this.lado4 = lado4;
    }
   
    public void calculo()
    {
        int operación;
        operación = lado1 + lado2 + lado3 + lado4;
        Console.WriteLine("el area del"+nombre+ "es de:" + operación); 
    }
}
