double entrada1, entrada2;
int resultado;

while (true)
{
    Console.WriteLine("Digite o primeiro número: ");
    entrada1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    entrada2 = Double.Parse(Console.ReadLine());

    resultado = (int) (entrada1 + entrada2);

    Console.Write($"O resultado da soma é: {resultado}");
    System.Threading.Thread.Sleep(5000);
    Console.Clear();
}

