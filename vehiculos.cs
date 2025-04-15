using System;

interface IVehiculos
{
    public void mover(double time){
        posicion += time * velocidad;
    }

    public double posicion(){
        return posicion;
    }

    public void reiniciarPosicionposicion(){
        posicion = 0;
    }
}

public class Auto : IFigura{
    private double posicion = 0;
    private double velocidad = 40;

    public Auto(double velocidad)
    {
        this.velocidadMax = velocidad;
    }
}

public class Bicicleta : IFigura{
    private double posicion = 0;
    private double velocidad = 10;
}

public class Camion : IFigura{
    private double posicion = 0;
    private double velocidad = 30;
}

public class Carrera{
    public vehiculo vehiculo1;
    public vehiculo vehiculo2;

    public Carrera(vehiculo vehiculo1, vehiculo vehiculo2)
    {
        this.vehiculo1 = vehiculo1;
        this.vehiculo2 = vehiculo2;
    }

    void hacerCarrera(int time){
        posiciones[2];
        posiciones[0] = ;
        Console.WriteLine("El vehiculo 1 se movio " + vehiculo1.posicion(vehiculo1.mover(time)) + " metros\n");
        Console.WriteLine("El vehiculo 2 se movio " + vehiculo2.posicion(vehiculo2.mover(time)) + " metros\n");
    }   

}


public class Program
{
    public static void Main()
    { 
        Auto fiat = new Auto(45);
        Bicicleta bici = new Bicicleta();
        Camion camion = new Camion();
        bici.mover(20);
        Console.WriteLine("bici posicion" + bici.posicion());
        bici.mover(10);
        Console.WriteLine("bici poscion nueva" + bici.posicion());
    }
}