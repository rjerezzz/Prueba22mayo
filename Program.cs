/*Integrante 1 va a crear los arreglos y definir las variables. Requerimiento 2*/

string[] productos = new string[15];
int[] cantidad = new int[15];
double[] precio = new double[15];
double suma = 0;

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
            for (int i = 0; i < productos.Length; i++)
            {
                {
                    try
                    {
                        Console.WriteLine($"Ingrese el nombre del producto {i + 1}: ");
                        productos[i] = Console.ReadLine();

                        Console.WriteLine($"Ingrese la cantidad del producto {i + 1}: ");
                        cantidad[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Ingrese el precio del producto {i + 1}: ");
                        precio[i] = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un valor correcto.");
                        Console.ResetColor();
                        i--;
                    }
                }
            }
            break;
        case 2:
            // Código para mostrar productos
            break;
        case 3:
            // Código para calcular total vendido
            break;
        case 4:
            // Código para mostrar producto más vendido
            break;
        case 5:
            // Código para mostrar promedio de ventas
            break;
        case 6:
            salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intente nuevamente.");
            break;
    }

}while (!salir);


/*Integrante 2 va a rellenar la info y validar las entradas. Requerimiento 1 */


for (int i = 0; i < productos.Length; i++)
{
    {
        try
        {
            Console.WriteLine($"Ingrese el nombre del producto {i + 1}: ");
            productos[i] = Console.ReadLine();

            Console.WriteLine($"Ingrese la cantidad del producto {i + 1}: ");
            cantidad[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ingrese el precio del producto {i + 1}: ");
            precio[i] = double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada inválida. Por favor, ingrese un valor correcto.");
            Console.ResetColor();
            i--;
        }
    }
}




/* Integrante 3 va a realizar los calculos y las estadisticas. Requerimiento 4, 6*/





/* Integrante 4 va a mostrar los resultados y corregir errores. Requerimientos 3, 5*/





