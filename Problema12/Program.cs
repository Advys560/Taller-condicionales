Console.Write("¿Tienes empleo? (si/no) ");
string? empleado = Console.ReadLine();
if (empleado == "si") {
    Console.Write("¿Cuál es tu salario? ");
    if (double.TryParse(Console.ReadLine(), out double salario))
    {
        if (salario ==1800000 )
            Console.WriteLine("Credito basico aprovado.");
        else if (salario >= 2500000)
            Console.WriteLine("Credito alto aprovado.");
        else
            Console.WriteLine("Salario insuficiente para aprobar el credito.");
    }
    else
        Console.WriteLine("NEcesitas un empleo para solicitar un credito.|");
}