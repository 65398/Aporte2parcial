using System;
public class Program
{


    public static void Main(String[] args)
    {

        //celular1
        Console.WriteLine("------------------------------------------");
        var telefono = new dispositivo1();
        Console.WriteLine(telefono.reparacion());

        var reparacion = new pantalla(telefono);
        Console.WriteLine(reparacion.reparacion());

        var reparacion2 = new agua(telefono);
        Console.WriteLine(reparacion2.reparacion());

        var reparacion3 = new formatear(telefono);
        Console.WriteLine(reparacion3.reparacion());

        Console.WriteLine(telefono.software());

        var Cargador = new cargador(telefono);
        Console.WriteLine(Cargador.software());
        Console.WriteLine("------------------------------------------");




        //celular2
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        var telefono2 = new dispositivo2();
        Console.WriteLine(telefono2.reparacion());

        var reparacion4 = new agua(telefono2);
        Console.WriteLine(reparacion4.reparacion());

        var reparacion5 = new formatear(telefono2);
        Console.WriteLine(reparacion5.reparacion());

        var reparacion6 = new pantalla(telefono);
        Console.WriteLine(reparacion6.reparacion());

        Console.WriteLine(telefono2.software());

        var parlante2 = new sonido(telefono2);
        Console.WriteLine(parlante2.software());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");


        //celular3
        var telefono3 = new dispositivo3();
        Console.WriteLine(telefono3.reparacion());

        var reparacion7 = new agua(telefono3);
        Console.WriteLine(reparacion7.reparacion());

        var reparacion8 = new formatear(telefono3);
        Console.WriteLine(reparacion8.reparacion());

        var reparacion9 = new pantalla(telefono3);
        Console.WriteLine(reparacion9.reparacion());

        Console.WriteLine(telefono3.software());

        var audifonos3 = new auriculares(telefono3);
        Console.WriteLine(audifonos3.software());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
    }
}