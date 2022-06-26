

//WHILE

Console.WriteLine("Introduce un número");
int a = int.Parse(Console.ReadLine());

int i = 1;

while(i <= 10)
{
    Console.WriteLine($"{a} x {i} = " + (a * i));
    i++;
}



//DO WHILE

int contPos = 0;
int contNeg = 0;

Console.WriteLine("Introduce un número");
int b = int.Parse(Console.ReadLine());
do
{
  if (b > 0)
    {
        contPos++;
        break;
    }else
    {
        contNeg++;
        break;
    }
    
} while (b != 0);


Console.WriteLine($"Contador positivo: {contPos}");
Console.WriteLine($"Contador negativo: {contNeg}");






//FOR


int ancho = 2;
int alto = 2;
int repeticiones = 3;
Boolean relleno = false;


    if (relleno)
    {

        for (int i = 1; i <= alto; i++)
        {

            for (int j = 1; j <= ancho; j++)
            {

                Console.Write("*");
            }
            Console.WriteLine("\n");
        }

    }
    else
    {
        for (int i = 1; i <= alto; i++)
        {
            if (i == 1 || i == alto)
            {
            for (int k = 1; k <= repeticiones; k++)
            {
                for (int j = 1; j <= ancho; j++)
            {
                
                    Console.Write("*");
                }
                Console.Write(' ');
            }
                Console.WriteLine("\n");
            }
            else
            {
            for (int k = 1; k <= repeticiones; k++)
            {
                for (int j = 1; j <= ancho; j++)
            {
               
                    if (j == 1 || j == alto)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(' ');
            }
                Console.WriteLine("\n");
            }
        }

    }


