object dato = "SENA"; // Cambiar para probar
switch (dato) {
    case string s: Console.WriteLine($"Texto de {s.Length} caracteres"); break;
    case int i: Console.WriteLine($"Entero: {i}"); break;
    case double d: Console.WriteLine($"Decimal: {d}"); break;
    case bool b: Console.WriteLine($"Booleano: {b}"); break;
    default: Console.WriteLine("Tipo no reconocido"); break;
}