double p = double.Parse(Console.ReadLine());
if (p <= 0) Console.WriteLine("Peso inválido");
else if (p < 1) Console.WriteLine("$8.000");
else if (p < 5) Console.WriteLine("$15.000");
else if (p < 20) Console.WriteLine("$32.000");
else Console.WriteLine("$60.000");