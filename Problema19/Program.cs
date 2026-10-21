int v = int.Parse(Console.ReadLine());
if (v < 0) Console.WriteLine("Lectura inválida");
else if (v <= 50) Console.WriteLine("Sin infracción");
else if (v <= 70) Console.WriteLine("Multa leve");
else if (v <= 90) Console.WriteLine("Multa grave");
else Console.WriteLine("Multa gravísima e inmovilización");