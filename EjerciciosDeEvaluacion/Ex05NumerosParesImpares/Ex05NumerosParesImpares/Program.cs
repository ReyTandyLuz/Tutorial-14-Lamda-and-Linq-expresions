/*Exercício 5: Agrupamento de Números Pares e Ímpares:
Dada uma lista de números, utilize LINQ para agrupar 
os números pares e ímpares em duas listas separadas.*/

using System.Globalization;

List<int> numeros;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 5 - Tutorial 14");

    numeros = new();

    do
    {
        numeros.Add(Int("\nQual número inteiro deseja inserir?: "));
    } while (Deseja("Deseja inserir outro número à lista?"));

    var numerosFiltrados = numeros.GroupBy(n => n % 2 == 0).ToList();

    Console.WriteLine();

    foreach (var grupo in numerosFiltrados)
    {
        Console.WriteLine($"\n\t{(grupo.Key ? "Números pares" : "Números impares")}\n");

        foreach(var numero in grupo.OrderBy(x => x))
            Console.WriteLine("\t\t" + numero);
    }

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

