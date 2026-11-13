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

        private void ValidarMonto(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor que cero.");
            if (monto % 10000 != 0)
                throw new ArgumentException("El monto debe ser múltiplo de $10.000.");
        }

        public void Depositar(decimal monto)
        {
            ValidarMonto(monto);
            Saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            ValidarMonto(monto);
            if (monto > Saldo)
                throw new InvalidOperationException("Saldo insuficiente.");
            Saldo -= monto;
        }

        public void Transferir(CuentaBancaria destino, decimal monto)
        {
            if (destino == null)
                throw new ArgumentException("La cuenta destino no es válida.");
            Retirar(monto);
            destino.Depositar(monto);
        }

        public override string ToString() =>
            $"Cuenta: {Numero} | Titular: {Titular} | Saldo: ${Saldo:N2}";
    }
}
