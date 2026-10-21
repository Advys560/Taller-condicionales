char c = char.ToLower(Console.ReadLine()[0]);
if (!char.IsLetter(c)) Console.WriteLine("No es una letra");
else if ("aeiou".Contains(c)) Console.WriteLine("Es vocal");
else Console.WriteLine("Es consonante");