Console.WriteLine("¿Cuál es tu nota? ");
double nota = double.Parse(Console.ReadLine());
string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";
Console.WriteLine($"Nota: {nota} {estado}");