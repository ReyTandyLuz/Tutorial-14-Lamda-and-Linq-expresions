/*Exercício 6: Concatenação de Strings com Condição:
Dada uma lista de strings, utilize LINQ para concatenar todas as strings que têm mais de cinco caracteres.*/

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

    palavras = palavras.Where(x => x.Length > 5).ToList();

    if (palavras.Count == 0)
        Console.WriteLine("\nNão existem palavras com mais de 5 caracteres ._.");

    else if(palavras.Count == 1)
        Console.WriteLine("\nPalavra com mais de cinco caracteres: " + palavras[0]);

    else
        Console.WriteLine("\nPalavras que superam os 5 carácteres: " + string.Join(", ", palavras));

} while (Deseja("Deseja inserir outra lista de palavras para concatenar?"));

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

            if (confirmacionPalabra.Length == 1)
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
