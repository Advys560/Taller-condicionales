Console.WriteLine("Ingrese su rol (admin, instructor, aprendiz):");
string? entradaRol = Console.ReadLine();
Console.WriteLine("Ingrese la hora (0-23):");
if (entradaRol is null || !int.TryParse(Console.ReadLine(), out int hora) || hora < 0 || hora > 23)
{
    Console.WriteLine("Rol u hora inválidos.");
    return;
}

string rol = entradaRol.Trim().ToLowerInvariant();
bool entra = (rol, hora) switch {
    ("admin", _) => true,
    ("instructor", >= 6 and <= 21) => true,
    ("aprendiz", >= 6 and <= 18) => true,
    _ => false
};
Console.WriteLine(entra ? "Acceso permitido" : "Acceso denegado");