int c = int.Parse(Console.ReadLine());
string msg = $"Tienes {c} articulo{(c == 1 ? "" : "s")} en el carrito";
Console.WriteLine(msg);