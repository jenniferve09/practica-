using System;
namespace ConsoleApp1;
public class figura
{
    public string nombre { set; get; }
    public string color { set; get; }
    public figura(string nombre, string color)
    {
        this.nombre = nombre;
        this.color = color;
    }
    public void imprimir()
    {
        Console.WriteLine("Nombre:" + nombre);

        Console.WriteLine("Color:" + color);
    }
    public void calculo ()
    {
        Console.WriteLine("el area es de:" + calculo); 
    }


}
