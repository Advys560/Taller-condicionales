Console.WriteLine("Ingrese su estatura en metros:");
if (!double.TryParse(Console.ReadLine(), out double est) || est < 0)
{
    Console.WriteLine("Estatura inválida.");
    return;
}

Console.WriteLine("Ingrese su edad:");
if (!int.TryParse(Console.ReadLine(), out int edad) || edad < 0)
{
    Console.WriteLine("Edad inválida.");
    return;
}

Console.WriteLine("¿Está acompañado? (true/false):");
if (!bool.TryParse(Console.ReadLine(), out bool acomp))
{
    Console.WriteLine("Respuesta inválida. Ingrese true o false.");
    return;
}

if (est >= 1.40 && (edad >= 12 || acomp)) Console.WriteLine("Puede subir");
else Console.WriteLine("No puede subir");