string estado = Console.ReadLine();
string msg = estado switch {
    "Rojo" => "Deténgase",
    "Amarillo" => "Precaución, prepárese para detenerse",
    "Verde" => "Avance",
    _ => "Inválido"
};
Console.WriteLine(msg);