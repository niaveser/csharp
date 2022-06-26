
DatosCliente miCliente = new DatosCliente();
miCliente.ShowClient("Ana López", "666998877", "Calle A", "aaa@gmail.com", true);


public struct DatosCliente
{
    public DatosCliente(string nombreCompleto, string telefono, string direccion, string correo, Boolean nuevoCliente)
    {
        name = nombreCompleto;
        phone = telefono;
        address = direccion;
        email = correo;
        newClient = nuevoCliente;

    }

    public string name { get; }
    public string phone { get; }
    public string address { get; }
    public string email { get; }

    public Boolean newClient { get; }

    public void ShowClient(string nombreCompleto, string telefono, string direccion, string correo, Boolean nuevoCliente)
    {
        Console.WriteLine("Nombre: " + nombreCompleto);
        Console.WriteLine("Teléfono: " + telefono);
        Console.WriteLine("Dirección: " + direccion);
        Console.WriteLine("Email: " + correo);
        Console.WriteLine("¿Es nuevo?: " + nuevoCliente);
    }

    
    public override string ToString()=> $"({name}, {phone}, {address}, {email}, {newClient})";
    
}