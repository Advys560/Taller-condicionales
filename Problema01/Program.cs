using System;
Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());
if (edad >= 16) {
    Console.WriteLine("Puede votar");
} else {
    Console.WriteLine("Aún no puede votar");
}