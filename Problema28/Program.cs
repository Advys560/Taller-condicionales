Console.WriteLine("Ingrese el valor de la compra:");
if (!double.TryParse(Console.ReadLine(), out double valor) ||
    !double.IsFinite(valor) || valor < 0)
{
    Console.WriteLine("Valor de compra inválido.");
    return;
}

Console.WriteLine("¿Es cliente frecuente? (true/false):");
if (!bool.TryParse(Console.ReadLine(), out bool frec))
{
    Console.WriteLine("Respuesta inválida. Ingrese true o false.");
    return;
}

double desc = valor >= 500000 ? 0.15 : valor >= 200000 ? 0.10 : valor >= 100000 ? 0.05 : 0;
if (frec && valor >= 100000) desc += 0.05;
Console.WriteLine($"descuento {desc:P0}, total ${valor * (1 - desc):N0}");