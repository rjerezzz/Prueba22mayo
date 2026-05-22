string[] productos = new string[15];
int[] cantidad = new int[15];
double[] precio = new double[15];
double suma = 0;
int contador = 0;

bool salir = false;

do
{
    Console.WriteLine("===== MENÚ =====");
    Console.WriteLine("1. Registrar productos");
    Console.WriteLine("2. Mostrar productos");
    Console.WriteLine("3. Calcular total vendido");
    Console.WriteLine("4. Mostrar producto más vendido");
    Console.WriteLine("5. Mostrar promedio de ventas");
    Console.WriteLine("6. Salir");

    Console.Write("Ingrese una opción: ");
    int.TryParse(Console.ReadLine(), out int opcion);

    switch (opcion)
    {
        case 1:

            if (contador >= productos.Length)
            {
                Console.WriteLine("No hay espacio para más productos.");
                break;
            }

            Console.WriteLine("Ingrese el nombre del producto:");
            productos[contador] = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Ingrese la cantidad:");

                if (int.TryParse(Console.ReadLine(), out cantidad[contador]))
                    break;

                Console.WriteLine("Solo números enteros.");
            }

            while (true)
            {
                Console.WriteLine("Ingrese el precio:");

                if (double.TryParse(Console.ReadLine(), out precio[contador]))
                    break;

                Console.WriteLine("Solo números válidos.");
            }

            contador++;

            break;

        case 2:
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Producto: {productos[i]} | Cantidad: {cantidad[i]} | Precio: {precio[i]}");
            }
            break;

        case 3:
            suma = 0;
            for (int i = 0; i < contador; i++)
            {
                suma += cantidad[i] * precio[i];
            }
            Console.WriteLine($"Total vendido: {suma}");
            break;

        case 4:
            int max = cantidad[0];
            string prod = productos[0];

            for (int i = 1; i < contador; i++)
            {
                if (cantidad[i] > max)
                {
                    max = cantidad[i];
                    prod = productos[i];
                }
            }

            Console.WriteLine($"Más vendido: {prod} ({max})");
            break;

        case 5:
            double total = 0;
            int cantTotal = 0;

            for (int i = 0; i < contador; i++)
            {
                total += cantidad[i] * precio[i];
                cantTotal += cantidad[i];
            }

            Console.WriteLine($"Promedio: {total / cantTotal}");
            break;

        case 6:
            salir = true;
            break;
    }

    Console.WriteLine();
    Console.WriteLine();

} while (!salir);