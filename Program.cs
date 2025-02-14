double entrada1, entrada2;
int resultado;
int escolha;

Console.WriteLine("Digite o número referente a operação que deseja realizar: ");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
escolha = int.Parse(Console.ReadLine());

switch(escolha) {
    case 1:
        Console.WriteLine("Digite o primeiro número: ");
        entrada1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        entrada2 = Double.Parse(Console.ReadLine());

        resultado = (int)(entrada1 + entrada2);

        Console.Write($"O resultado da soma é: {resultado}");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
        break;

    case 2:
        Console.WriteLine("Digite o primeiro número: ");
        entrada1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        entrada2 = Double.Parse(Console.ReadLine());

        resultado = (int)(entrada1 - entrada2);

        Console.Write($"O resultado da soma é: {resultado}");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
        break;

    case 3:
        Console.WriteLine("Digite o primeiro número: ");
        entrada1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        entrada2 = Double.Parse(Console.ReadLine());

        resultado = (int)(entrada1 * entrada2);

        Console.Write($"O resultado da soma é: {resultado}");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
        break;

    case 4:
        Console.WriteLine("Digite o primeiro número: ");
        entrada1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        entrada2 = Double.Parse(Console.ReadLine());

        resultado = (int)(entrada1 / entrada2);

        Console.Write($"O resultado da soma é: {resultado}");
        System.Threading.Thread.Sleep(5000);
        Console.Clear();
        break;
    default:
        Console.WriteLine("Número inválido :(");
        break;
    }

