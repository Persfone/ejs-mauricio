using System;

interface Jugador
{
    private string tipo;
    private int minutosCorrer;
    public Jugador(string tipo, int minutosCorrer)
    {
        this.tipo = tipo;
        if(tipo == "Profesional")
        {
            this.minutosCorrer = 40;
        }
        else
        {
            this.minutosCorrer = 20;
        }
        
    }

    
    public bool cansado()
    {
        if (minutosCorrer == 0)
        {
            Console.WriteLine("El jugador esta cansado");
            return true;
        }
        Console.WriteLine("El jugador no esta cansado");
        return false;
    }

    public void descansar(int minutos)
    {
        Console.WriteLine("Descansando...");
        minutosCorrer += minutos;
        if (tipo == "Amateur" && minutosCorrer > 20)
        {
            minutosCorrer = 20;
        }
        else if (tipo == "Profesional" && minutosCorrer > 40)
        {
            minutosCorrer = 40;
        }
    }

    public bool correr(int minutos)
    {
        if (minutos > minutosCorrer)
        {
            Console.WriteLine("El jugador llego a su limite, le faltaron correr" + minutos-minutosCorrer + " minutos");
            minutosCorrer = 0;
            return false;
        }
        else
        {
            minutosCorrer -= minutos;
            Console.WriteLine("Corriendo...");
            return true;
        }
    }
}


public class Program
{
    public static void Main()
    {
        Cronometro cronometro = new Cronometro(0, 0);

        Console.WriteLine("Cronometro iniciado");
        for (int i = 0; i < 5000; i++)
        {
            cronometro.IncrementarTiempo();
            cronometro.MostrarTiempo();
        }
    }
}