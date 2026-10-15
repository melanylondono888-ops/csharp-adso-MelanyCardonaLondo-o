using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int saldo = 500000;
            int pin = 1234;
            int intentos = 0;
            bool acceso = false;

            Console.WriteLine("CAJERO AUTOMATICO");

            // Validar PIN: máximo 3 intentos
            do
            {
                Console.Write("Ingresa tu PIN: ");

                if (int.TryParse(Console.ReadLine(), out int clave)
                    && clave == pin)
                {
                    Console.WriteLine("PIN correcto. Bienvenido.");
                    acceso = true;
                }
                else
                {
                    intentos++;
                    Console.WriteLine("PIN incorrecto.");
                }

            } while (!acceso && intentos < 3);

            if (!acceso)
            {
                Console.WriteLine("Tarjeta bloqueada");
                return;
            }

            // Menú del cajero
            int opc;

            do
            {
                Console.WriteLine("\n¿QUE DESEAS HACER HOY?");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opc))
                {
                    Console.WriteLine("Debes ingresar una opcion numerica.");
                    opc = 0;
                    continue;
                }

                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"Tu saldo es: ${saldo:N0}");
                        break;

                    case 2:
                        Console.Write("¿Cuanto deseas depositar?: ");

                        if (int.TryParse(Console.ReadLine(), out int deposito)
                            && deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine("Deposito realizado.");
                            Console.WriteLine($"Tu saldo actual es: ${saldo:N0}");
                        }
                        else
                        {
                            Console.WriteLine("Deposito invalido. Ingresa un numero positivo.");
                        }
                        break;

                    case 3:
                        Console.Write("¿Cuanto deseas retirar?: ");

                        if (int.TryParse(Console.ReadLine(), out int retiro)
                            && retiro > 0)
                        {
                            if (retiro % 10000 != 0)
                            {
                                Console.WriteLine("El retiro debe ser multiplo de $10.000.");
                            }
                            else if (retiro > saldo)
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                            else
                            {
                                saldo -= retiro;
                                Console.WriteLine("Retiro realizado.");
                                Console.WriteLine($"Tu saldo actual es: ${saldo:N0}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Retiro invalido. Ingresa un numero positivo.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el cajero.");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

            } while (opc != 4);

        }
    }
}
