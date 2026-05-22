for (int i = 0; i < contador; i++) // Requerimiento 3
            {
                Console.WriteLine($"Producto: {productos[i]} | Cantidad: {cantidad[i]} | Precio: {precio[i]}");
            }


            double total = 0;
            int cantTotal = 0;

            for (int i = 0; i < contador; i++) // Requerimiento 5
            {
                total += cantidad[i] * precio[i];
                cantTotal += cantidad[i];
            }

            Console.WriteLine($"Promedio: {total / cantTotal}");
            break;

/* Integrante 4 va a mostrar los resultados y corregir errores. Requerimientos 3, 5*/