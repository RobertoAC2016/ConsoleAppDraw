// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa tamaño de la matriz:");

int size = 0;
try
{
    size = int.Parse(Console.ReadLine());
}
catch(Exception ex)
{
    size = 1;
}

Console.WriteLine();
Console.WriteLine("Diagonal");
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (i == j) 
            Console.Write($" 1");
        else
            Console.Write($" .");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Cruz");
Console.WriteLine();

int left = size - 1;
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (left == j)
            Console.Write($" 1");
        else
            if (i == j)
                Console.Write($" 1");
            else
                Console.Write($" .");
    }
    Console.WriteLine();
    left--;
}

Console.WriteLine();
Console.WriteLine("Cuadro");
Console.WriteLine();

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (j == 0 || j == (size - 1))
            Console.Write(" 1");
        else
        if (i == 0 || i == (size - 1))
            Console.Write(" 1");
        else
            Console.Write(" .");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();