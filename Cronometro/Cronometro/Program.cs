using System;

namespace Cronometro
{
    public class Cronometro
    {
        private int contadorS = 0;
        private int contadorM = 0;

        public Cronometro(int contadorS, int contadorM)
        {
            this.contadorS = contadorS;
            this.contadorM = contadorM;
        }

        public void Reiniciar()
        {
            contadorS = 0;
            contadorM = 0;
        }

        public void IncrementarTiempo()
        {
            contadorS++;
            if (contadorS == 60)
            {
                contadorS = 0;
                contadorM++;
            }
        }

        public void MostrarTiempo()
        {
            Console.WriteLine(contadorM + " minutos, " + contadorS + " segundos");
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
}