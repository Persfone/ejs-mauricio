using System;

namespace CuentaBancaria
{

    public class CuentaBancaria
    {
        private string numeroCuenta;
        private string titular;
        private double saldo;

        public CuentaBancaria(string numeroCuenta, string titular, double saldoInicial)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        public double obtenerSaldo(CuentaBancaria cuenta)
        {
            return cuenta.saldo;
        }

        public void modificarSaldo(CuentaBancaria cuenta, double cantidad)
        {
            cuenta.saldo = cantidad;
        }
    }

    public class Banco
    {
        public void Depositar(CuentaBancaria cuenta, double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a depositar debe ser positiva.");
            }
            else
            {
                cuenta.modificarSaldo(cuenta, cuenta.obtenerSaldo(cuenta) + cantidad);
            }
        }

        public void Extraer(CuentaBancaria cuenta, double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a extraer debe ser positiva.");
            }
            else if (cantidad > cuenta.obtenerSaldo(cuenta))
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else
            {
                cuenta.modificarSaldo(cuenta, cuenta.obtenerSaldo(cuenta) - cantidad);
            }
        }

        public bool Transferir(CuentaBancaria cuentaOrigen, CuentaBancaria cuentaDestino, double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a transferir debe ser positiva.");
                return false;
            }
            else if (cantidad > cuentaOrigen.obtenerSaldo(cuentaOrigen))
            {
                Console.WriteLine("Fondos insuficientes en la cuenta de origen.");
                return false;
            }
            else 
            { 
                cuentaOrigen.modificarSaldo(cuentaOrigen, cuentaOrigen.obtenerSaldo(cuentaOrigen) - cantidad);
                cuentaDestino.modificarSaldo(cuentaDestino, cuentaDestino.obtenerSaldo(cuentaDestino) + cantidad);
                return true;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
