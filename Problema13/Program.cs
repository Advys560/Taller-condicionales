Console.WriteLine("Introduce el codigo de tu pais ej(CO, MX, US, etc): ");
string? codigo = Console.ReadLine();
string mensaje = codigo switch
{
    "CO" => "Bienvenido a Colombia",
    "MX" => "Bienvenido a Mexico",
    "US" => "Bienvenido a Estados Unidos",
    "AR" => "Bienvenido a Argentina",
    "PE" => "Bienvenido a Peru",
    "CL" => "Bienvenido a Chile",
    _ => "Codigo de pais no reconocido"
};
Console.WriteLine(mensaje);
