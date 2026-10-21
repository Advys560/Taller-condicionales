int d = int.Parse(Console.ReadLine());
string res = d switch { >= 1 and <= 5 => "Día hábil", 6 or 7 => "Fin de semana", _ => "Día inválido" };
Console.WriteLine(res);