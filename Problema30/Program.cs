Console.WriteLine("Ingrese la primera nota (0-100):");
if (!double.TryParse(Console.ReadLine(), out double n1) || n1 < 0 || n1 > 100)
{
    Console.WriteLine("Nota inválida.");
    return;
}

Console.WriteLine("Ingrese la segunda nota (0-100):");
if (!double.TryParse(Console.ReadLine(), out double n2) || n2 < 0 || n2 > 100)
{
    Console.WriteLine("Nota inválida.");
    return;
}

Console.WriteLine("Ingrese la tercera nota (0-100):");
if (!double.TryParse(Console.ReadLine(), out double n3) || n3 < 0 || n3 > 100)
{
    Console.WriteLine("Nota inválida.");
    return;
}

double prom = (n1 + n2 + n3) / 3.0;
char let = prom switch { >= 90 => 'A', >= 80 => 'B', >= 70 => 'C', >= 60 => 'D', _ => 'F' };
string msg = let switch { 'A' => "Desempeño excelente", 'B' or 'C' => "Buen desempeño, sigue así", 'D' => "Aprobado, refuerza los temas", _ => "Debe presentar plan de mejoramiento" };
string estado = prom >= 60 ? "Aprobado" : "Reprobado";
string honor = prom == 100 ? " | ¡Mención de honor!" : "";
Console.WriteLine($"Promedio: {prom:F1} | Letra: {let} | {msg} | {estado}{honor}");