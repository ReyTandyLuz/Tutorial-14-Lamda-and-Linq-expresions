/*Exercício 2: Maior Palavra em uma Lista:
Dada uma lista de palavras, utilize LINQ para encontrar e imprimir a palavra com o maior número de letras.*/

using System.Globalization;

List<string> palavras;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 2 - Tutorial 14");

    palavras = new();

    do
    {
        palavras.Add(String("\nQual palavra deseja inserir?: "));
    } while (Deseja("Deseja inserir outra palavra à lista?"));

    var palavrasOrdenadas = palavras.OrderByDescending(x => x.Length).ToList();

    Console.WriteLine($"\nPalavras ordenadas mais longa é {palavrasOrdenadas[0]}: \n");

} while (Deseja("Deseja inserir outra lista de palavras?"));

string String(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write(enunciado);
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            var confirmacionPalabra = texto.Trim().Split(' ');

            if(confirmacionPalabra.Length == 1)
                return texto.Trim();
        }

        Console.WriteLine("\n\tValor invalido!!!!!! Tente novamente");
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