string[] productos = new string[15];
int[] cantidad = new int[15];
double[] precio = new double[15];
double suma = 0;

        case 2:
            // Código para mostrar productos
            for(int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Producto: {productos[i]}, Cantidad: {cantidad[i]}, Precio: {precio[i]}");
            }
            break;
        case 3:
            // Código para calcular total vendido
            suma = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                suma += cantidad[i] * precio[i];
            }
            Console.WriteLine($"Total vendido: {suma}");
            break;
        case 4:
            // Código para mostrar producto más vendido
            int maxCantidad = cantidad[0];
            string productoMasvendido = productos[0];
            for (int i = 1; i < cantidad.Length; i++)
            {
                if (cantidad[i] > maxCantidad)
                    {
                        maxCantidad = cantidad[i];
                        productoMasvendido = productos[i];
                    }
                }
                Console.WriteLine($"Producto más vendido: {productoMasvendido}, Cantidad: {maxCantidad}");
            break;
        case 5:
            // Código para mostrar promedio de ventas
            double promedio = 0;
            int totalProductos = 0;
            for (int i = 0; i < cantidad.Length; i++)
            {
                promedio += cantidad[i] * precio[i];
                totalProductos += cantidad[i];
            }
            Console.WriteLine($"Promedio de ventas: {promedio / totalProductos}");
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



/* Integrante 4 va a mostrar los resultados y corregir errores. Requerimientos 3, 5*/





