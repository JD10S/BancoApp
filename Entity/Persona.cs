using System;
using Datos1;


namespace Entity
{
    public class Persona
    {
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Persona()
        {

        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Credenciales credenciales { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }
    }
    public class CuentaBancaria
    {
        public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
        {
            NumeroCuenta = numeroCuenta;
            Saldo = saldoInicial;
        }
    public string NumeroCuenta { get; }
    public decimal Saldo { get; private set; }

    public void Consignar(decimal valor)
    {
        Saldo += valor;
    }

    public bool Retirar(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }
    }

}

