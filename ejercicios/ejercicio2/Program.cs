//Variables

Console.WriteLine("Introduce tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Introduce tu apellido:");
string apellido = Console.ReadLine();
Console.WriteLine("Introduce tu edad:");
string edad = Console.ReadLine();
Console.WriteLine("¿Sabes programar?:");
string isDeveloper = Console.ReadLine();

Console.WriteLine("Me llamo " + nombre + " " + apellido + ", tengo " +
    edad + " años. " + isDeveloper + " sé programar.");

//Tipos de datos

int puertasCoche = 5;
int ruedasCoche = 4;
Boolean itvVigente = true;


float pesoMesa = 23.25f;
int largoMesa = 150;
string materialMesa = "madera";
string colorMesa = "blanca";

//Operadores

int a = 18;
Console.WriteLine(a >= 18);
char b = 'a';
Console.WriteLine(b=='a');
Console.WriteLine(a >= 18 && b == 'a');
Console.WriteLine(a >= 18 || b == 'b');