/*Integrante 1 va a crear los arreglos y definir las variables. Requerimiento 2*/
//Productos, cantidad, precio



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





