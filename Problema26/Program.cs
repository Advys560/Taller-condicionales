char cat = char.ToUpper(Console.ReadLine()[0]);
int tarifa = cat switch { 'M' => 0, 'A' => 12000, 'B' => 25000, 'C' => 38000, _ => throw new ArgumentException("Categoría desconocida") };
Console.WriteLine($"Categoría {cat} Tarifa: ${tarifa}");