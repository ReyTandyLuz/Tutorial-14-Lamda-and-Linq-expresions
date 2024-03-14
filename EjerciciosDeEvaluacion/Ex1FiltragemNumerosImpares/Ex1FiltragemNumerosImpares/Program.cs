/*Exercício 1: Filtragem de Números Ímpares:
Dada uma lista de números, utilize LINQ para selecionar e imprimir apenas os números ímpares.*/

using System.Globalization;

List<int> numeros;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 1 - Tutorial 14");

    numeros = new();

    do
    {
        numeros.Add(Int("\nQual número inteiro deseja inserir?: "));
    } while (Deseja("Deseja inserir outro número à lista?"));

    var numerosImpares = numeros.Where(x => x % 2 != 0);
    numerosImpares = numerosImpares.OrderByDescending(x => x);

     Console.WriteLine();

    foreach (int i in numerosImpares)
        Console.WriteLine($"\t{i}");

} while (Deseja("Deseja inserir outra lista de números?"));

int Int(string enunciado)
{
    while (true)
    {
        Console.Write(enunciado);
        if (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out int result))
            return result;

        Console.WriteLine("\nNúmero inválido!!!! Tente novamente");
    }
}

bool Deseja(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write($"\n{enunciado} Sim/Não?: ");
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            if (texto.ToLower() == "sim")
                return true;

            if (texto.ToLower() == "não" || texto.ToLower() == "nao")
                return false;
        }

        Console.WriteLine("\nOpção inválida!!!!! É SIM/NÃO!!!");
    }
}
