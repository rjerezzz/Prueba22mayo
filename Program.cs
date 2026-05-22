
// Código para calcular total vendido
suma = 0;
for (int i = 0; i < productos.Length; i++)
    {
    suma += cantidad[i] * precio[i];
    }
Console.WriteLine($"Total vendido: {suma}");

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






