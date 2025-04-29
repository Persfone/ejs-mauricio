using System;

namespace Vehiculos
{
    interface IVehiculos
    {
        void Mover(double tiempo);
        double PosicionActual();
        void ReiniciarPosicion();
    }

    public class Auto : IVehiculos
    {
        private double posicion = 0;
        private double velocidad = 40;

        public Auto(double velocidad)
        {
            this.velocidad = velocidad;
        }

        public void Mover(double tiempo)
        {
            posicion += tiempo * velocidad;
        }

        public double PosicionActual()
        {
            return posicion;
        }

        public void ReiniciarPosicion()
        {
            posicion = 0;
        }
    }

    public class Bicicleta : IVehiculos
    {
        private double posicion = 0;
        private double velocidad = 10;

        public void Mover(double tiempo)
        {
            posicion += tiempo * velocidad;
        }

        public double PosicionActual()
        {
            return posicion;
        }

        public void ReiniciarPosicion()
        {
            posicion = 0;
        }
    }

    public class Camion : IVehiculos
    {
        private double posicion = 0;
        private double velocidad = 30;

        public void Mover(double tiempo)
        {
            posicion += tiempo * velocidad;
        }

        public double PosicionActual()
        {
            return posicion;
        }

        public void ReiniciarPosicion()
        {
            posicion = 0;
        }
    }

    public class Carrera
    {
        private IVehiculos vehiculo1;
        private IVehiculos vehiculo2;

        public Carrera(IVehiculos vehiculo1, IVehiculos vehiculo2)
        {
            this.vehiculo1 = vehiculo1;
            this.vehiculo2 = vehiculo2;
        }

        public void HacerCarrera(int tiempo)
        {
            vehiculo1.Mover(tiempo);
            vehiculo2.Mover(tiempo);

            Console.WriteLine("El vehículo 1 se movió " + vehiculo1.PosicionActual() + " metros.");
            Console.WriteLine("El vehículo 2 se movió " + vehiculo2.PosicionActual() + " metros.");
        }
    }

    class Program
    {
        static void Main()
        {
            Auto fiat = new Auto(45);
            Bicicleta bici = new Bicicleta();
            Camion camion = new Camion();

            bici.Mover(20);
            Console.WriteLine("Posición inicial de la bicicleta: " + bici.PosicionActual());

            bici.Mover(10);
            Console.WriteLine("Nueva posición de la bicicleta: " + bici.PosicionActual());

            Carrera carrera = new Carrera(fiat, bici);
            carrera.HacerCarrera(30);
        }
    }
}
