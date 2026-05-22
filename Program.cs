/*Integrante 1 va a crear los arreglos y definir las variables. Requerimiento 2*/
//Productos, cantidad, precio



/*Integrante 2 va a rellenar la info y validar las entradas. Requerimiento 1 */



for (int i = 0; i < productos.Length; i++)
{
    Console.WriteLine($"Ingrese el nombre del producto {i + 1}: ");
    productos[i] = Console.ReadLine();

    if (productos[i] == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El nombre no puede estar vacío.");
        Console.ResetColor();
        i--;
    }
    else
    {
        Console.WriteLine($"Ingrese la cantidad del producto {i + 1}: ");

        if (int.TryParse(Console.ReadLine(), out cantidad[i]))
        {
            Console.WriteLine($"Ingrese el precio del producto {i + 1}: ");

            if (!double.TryParse(Console.ReadLine(), out precio[i]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Precio inválido, ingrese números enteros o números enteros con decimales.");
                Console.ResetColor();
                i--;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cantidad inválida, ingrese solo un número entero.");
            Console.ResetColor();
            i--;
        }
    }
}




/* Integrante 3 va a realizar los calculos y las estadisticas. Requerimiento 4, 6*/





/* Integrante 4 va a mostrar los resultados y corregir errores. Requerimientos 3, 5*/





