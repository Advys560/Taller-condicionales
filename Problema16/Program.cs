Console.WriteLine("Cuales son las coordenadas (X, Y) del drone? (ej: 3, 4) ");
string? entrada = Console.ReadLine();
if (entrada is null)
{
    Console.WriteLine("Coordenadas no reconocidas");
    return;
}

string[] coordenadas = entrada.Split(',');
if (coordenadas.Length != 2 ||
    !double.TryParse(coordenadas[0], out double x) ||
    !double.TryParse(coordenadas[1], out double y))
{
    Console.WriteLine("Coordenadas no reconocidas");
    return;
}

string zona = (x, y) switch
{
    var (coordX, coordY) when coordX >= 0 && coordY >= 0 => "Zona Norte",
    var (coordX, coordY) when coordX < 0 && coordY >= 0 => "Zona Oeste",
    var (coordX, coordY) when coordX < 0 && coordY < 0 => "Zona Sur",
    var (coordX, coordY) when coordX >= 0 && coordY < 0 => "Zona Este",
    _ => "Coordenadas no reconocidas"
};
Console.WriteLine(zona);
