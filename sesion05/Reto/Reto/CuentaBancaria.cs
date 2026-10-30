using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    internal class CuentaBancaria
    {

        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }

        // Constructor con saldoInicial opcional (por defecto 0)
        public CuentaBancaria(string titular, string numero, decimal saldoInicial = 0)
        {
            if (string.IsNullOrWhiteSpace(titular))
                throw new ArgumentException("El titular no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(numero))
                throw new ArgumentException("El número de cuenta es obligatorio.");

            if (saldoInicial < 0)
                throw new ArgumentException("El saldo inicial no puede ser negativo.");

            Titular = titular;
            Numero = numero;
            Saldo = saldoInicial;
        }

        // Método para Depositar (monto > 0)
        public bool Depositar(decimal monto)
        {
            if (monto <= 0) return false;

            Saldo += monto;
            return true;
        }

        // Método para Retirar (monto > 0 y <= Saldo)
        public bool Retirar(decimal monto)
        {
            if (monto <= 0 || monto > Saldo) return false;

            Saldo -= monto;
            return true;
        }

        // Método para Transferir a otra cuenta
        public bool Transferir(CuentaBancaria destino, decimal monto)
        {
            if (destino == null || monto <= 0 || monto > Saldo) return false;

            // Retiramos de la cuenta origen
            if (Retirar(monto))
            {
                // Depositamos en la cuenta destino
                destino.Depositar(monto);
                return true;
            }

            return false;
        }

        public override string ToString() =>
            $"Cuenta: {Numero} | Titular: {Titular} | Saldo: ${Saldo:N2}";

    }
}
