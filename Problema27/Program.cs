Console.WriteLine("Ingrese el día de la visita:");
string? entradaDia = Console.ReadLine();
if (entradaDia is null)
{
    Console.WriteLine("Día inválido.");
    return;
}

string dia = entradaDia.Trim().ToLowerInvariant();
if (dia == "sabado") dia = "sábado";
if (dia == "miercoles") dia = "miércoles";
if (dia != "lunes" && dia != "martes" && dia != "miércoles" &&
    dia != "jueves" && dia != "viernes" && dia != "sábado" && dia != "domingo")
{
    Console.WriteLine("Día inválido.");
    return;
}

Console.WriteLine("¿Es estudiante? (true/false):");
if (!bool.TryParse(Console.ReadLine(), out bool est))
{
    Console.WriteLine("Respuesta inválida. Ingrese true o false.");
    return;
}

int precio = dia == "martes" ? 7000 :
             (dia == "sábado" || dia == "domingo") ? 15000 :
             est ? 9000 : 12000;
Console.WriteLine($"${precio:N0}");