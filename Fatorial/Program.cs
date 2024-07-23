Console.WriteLine("Fatorial");

Console.Write("Digite um número para acha o fatorial :");
var numero = Convert.ToInt32(Console.ReadLine());
var resultado = Fatorial(numero);
Console.WriteLine($"O {numero}! é {resultado};");

static long Fatorial(int n)
{
    if (n <= 1)
        return 1;
    else
        return n * Fatorial(n - 1);
}
    
