double p = 70, e = 1.75; // Leer entradas
double imc = p / (e * e);
string cat = imc switch {
    < 18.5 => "Bajo peso",
    < 25 => "Peso normal",
    < 30 => "Sobrepeso",
    _ => "Obesidad"
};
Console.WriteLine($"IMC: {imc:F1} {cat}");