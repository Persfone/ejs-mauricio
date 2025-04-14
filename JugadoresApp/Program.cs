using System;

interface IJugador
{
    bool correr(int minutos);
    bool cansado();
    void descansar(int minutos);
}

class JugadorAmateur : IJugador
{
    private int minutosCorrer;
    private const int MaxMinutos = 20;

    public JugadorAmateur()
    {
        minutosCorrer = MaxMinutos;
    }

    public bool correr(int minutos)
    {
        if (minutos > minutosCorrer)
        {
            Console.WriteLine($"El jugador amateur llegó a su límite, le faltaron correr {minutos - minutosCorrer} minutos.");
            minutosCorrer = 0;
            return false;
        }
        else
        {
            minutosCorrer -= minutos;
            Console.WriteLine("El jugador amateur está corriendo...");
            return true;
        }
    }

    public bool cansado()
    {
        if (minutosCorrer == 0)
        {
            Console.WriteLine("El jugador amateur está cansado.");
            return true;
        }
        Console.WriteLine("El jugador amateur no está cansado.");
        return false;
    }

    public void descansar(int minutos)
    {
        Console.WriteLine("El jugador amateur está descansando...");
        minutosCorrer += minutos;
        if (minutosCorrer > MaxMinutos)
        {
            minutosCorrer = MaxMinutos;
        }
    }
}

class JugadorProfesional : IJugador
{
    private int minutosCorrer;
    private const int MaxMinutos = 40;

    public JugadorProfesional()
    {
        minutosCorrer = MaxMinutos;
    }

    public bool correr(int minutos)
    {
        if (minutos > minutosCorrer)
        {
            Console.WriteLine($"El jugador profesional llegó a su límite, le faltaron correr {minutos - minutosCorrer} minutos.");
            minutosCorrer = 0;
            return false;
        }
        else
        {
            minutosCorrer -= minutos;
            Console.WriteLine("El jugador profesional está corriendo...");
            return true;
        }
    }

    public bool cansado()
    {
        if (minutosCorrer == 0)
        {
            Console.WriteLine("El jugador profesional está cansado.");
            return true;
        }
        Console.WriteLine("El jugador profesional no está cansado.");
        return false;
    }

    public void descansar(int minutos)
    {
        Console.WriteLine("El jugador profesional está descansando...");
        minutosCorrer += minutos;
        if (minutosCorrer > MaxMinutos)
        {
            minutosCorrer = MaxMinutos;
        }
    }
}

public class Program
{
    public static void Main()
    {
        IJugador jugadorAmateur = new JugadorAmateur();
        IJugador jugadorProfesional = new JugadorProfesional();

        Console.WriteLine("Jugador Amateur:");
        jugadorAmateur.correr(15);
        jugadorAmateur.cansado();
        jugadorAmateur.descansar(10);
        jugadorAmateur.correr(10);
        jugadorAmateur.cansado();

        Console.WriteLine("\nJugador Profesional:");
        jugadorProfesional.correr(30);
        jugadorProfesional.cansado();
        jugadorProfesional.descansar(15);
        jugadorProfesional.correr(20);
        jugadorProfesional.cansado();
    }
}