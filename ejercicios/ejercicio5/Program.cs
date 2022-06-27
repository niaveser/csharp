//IF

Console.WriteLine("Introduzca su nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Introduza su email:");
string email = Console.ReadLine();
Console.WriteLine("Indique Sí o No si tiene cupón de descuento");
string cupon = Console.ReadLine();

float precio = 15.99f;


if (cupon == "Sí" || cupon == "Si")
{
    Console.WriteLine($"Cliente: {nombre}\nEmail: {email}\nTiene un cupón del \'15%' de descuento.\n" +
        $"Precio del producto: {precio}. Total con descuento: {(float)System.Math.Round(precio - (precio*0.15), 2)}");
}else if (cupon == "No")
{
    Console.WriteLine($"Cliente: {nombre}\nEmail: {email}\nNo tiene cupones aplicables.\n" +
        $"Precio del producto: {precio}. Total: {precio}");
}else
{
    Console.WriteLine("Error");
}




//SWITCH

List<string> lenguajes = new List<string>();
lenguajes.Add("C#");
lenguajes.Add("Java");
lenguajes.Add("C++");

Console.WriteLine("Introduce 1, 2 o 3 para elegir tu lenguaje");

for (int i = 0; i < lenguajes.Count; i++)
{
    Console.WriteLine((i+1) +". " + lenguajes[i]);
}

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Tu lenguaje es C#");
        break;
    case 2:
        Console.WriteLine("Tu lenguaje es Java");
        break;
    case 3:
        Console.WriteLine("Tu lenguaje es C++");
        break;
    default: 
        Console.WriteLine("Selección incorrecta");
        break;
}
