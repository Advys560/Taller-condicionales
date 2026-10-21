string j1 = Console.ReadLine(), j2 = Console.ReadLine();
if (j1 == j2) Console.WriteLine("Empate");
else if ((j1 == "piedra" && j2 == "tijera") || (j1 == "tijera" && j2 == "papel") || (j1 == "papel" && j2 == "piedra"))
    Console.WriteLine("Gana el jugador 1");
else Console.WriteLine("Gana el jugador 2");