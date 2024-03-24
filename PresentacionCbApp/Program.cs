
using Entity;

class Program
{
    static void Main(string[] args)
    {
        Persona cliente = null;

        do
        {
            Console.WriteLine("Bienvenido a BApp");
            Console.WriteLine("1. Registrarse");
            Console.WriteLine("2. Operaciones Bancarias");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("Opción no válida. ");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el apellido: ");
                    string apellido = Console.ReadLine();
                    cliente = new Persona(nombre, apellido);
                    Console.Write("Ingrese el número de cuenta: ");
                    string numeroCuenta = Console.ReadLine();
                    Console.Write("Ingrese el saldo de apertura: ");

                    if (!decimal.TryParse(Console.ReadLine(), out decimal saldoInicial))
                    {
                        Console.WriteLine("Saldo inicial inválido, Intente nuevamente.");
                        continue;
                    }

                    cliente.CuentaBancaria = new CuentaBancaria(numeroCuenta, saldoInicial);
                    Console.WriteLine("Cliente registrado correctamente.");
                    break;

                case 2:
                    if (cliente == null)
                    {
                        Console.WriteLine("Primero debe registrarse como cliente.");
                        break;
                    }

                    Console.WriteLine("1. Consignar");
                    Console.WriteLine("2. Retirar");
                    Console.WriteLine("3. Consultar saldo");
                    Console.WriteLine("4. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out int opcionOperacion))
                    {
                        Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                        continue;
                    }

                    switch (opcionOperacion)
                    {
                        case 1:
                            Console.Write("Ingrese el valor a consignar: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal valorConsignacion))
                            {
                                Console.WriteLine("Valor de consignación inválido. Intente nuevamente.");
                                continue;
                            }
                            cliente.CuentaBancaria.Consignar(valorConsignacion);
                            Console.WriteLine("¡Consignación exitosa!");
                            break;

                        case 2:
                            Console.Write("Ingrese el valor a retirar: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal valorRetiro))
                            {
                                Console.WriteLine("Valor de retiro inválido. Intente nuevamente.");
                                continue;
                            }
                            if (cliente.CuentaBancaria.Retirar(valorRetiro))
                            {
                                Console.WriteLine("¡Retiro exitoso!");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                            }
                            break;

                        case 3:
                            Console.WriteLine($"El saldo actual de la cuenta es: {cliente.CuentaBancaria.Saldo}");
                            break;

                        case 4:
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Saliendo de BApp...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

        } while (cliente == null || cliente.CuentaBancaria == null || cliente.CuentaBancaria.Saldo == 0);

        Console.WriteLine("¡Gracias por utilizar BApp!");
    }
}





