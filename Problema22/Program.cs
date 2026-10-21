int a = 12, b = 4; char op = '*'; // Entradas
switch (op) {
    case '+': Console.WriteLine(a + b); break;
    case '-': Console.WriteLine(a - b); break;
    case '*': Console.WriteLine(a * b); break;
    case '/': 
        if (b == 0) throw new DivideByZeroException("No se puede dividir entre cero");
        Console.WriteLine(a / b); break;
    default: throw new ArgumentException("Operador no soportado");
}