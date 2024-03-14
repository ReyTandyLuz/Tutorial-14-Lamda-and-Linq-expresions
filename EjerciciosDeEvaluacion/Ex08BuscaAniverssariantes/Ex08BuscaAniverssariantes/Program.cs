/*Dada uma lista de objetos do tipo Pessoa (com propriedades Nome e Data de Nascimento), utilize LINQ para en-
contrar e imprimir todas as pessoas que fazem aniversário em um determinado mês.*/

using Ex08BuscaAniverssariantes.Entities;
using System.Globalization;

List<Pessoa> pessoas;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 8 - Tutorial 14");

    pessoas = [];

    do
    {
        pessoas.Add(Pessoa());
    } while(DesejaContinuar("Deseja inserir outra pessoa mais?"));

    pessoas = pessoas.Where(p => Validacion(p)).ToList();

    if (pessoas.Count == 0)
        Console.WriteLine("\nNenhuma pessoa está de aniverssário hoje");

    else if (pessoas.Count == 1)
        Console.WriteLine($"\nA única pessoa que faz anos hoje é: {pessoas[0]}");

    else
    {
        Console.WriteLine("\nPessoas que estão de aniverssário hoje:\n");

        Console.WriteLine("\t" + string.Join("\n\t", pessoas));
    }

} while (DesejaContinuar("Deseja inserir outras pessoas diferentes?"));

Pessoa Pessoa()
{
    string nome = String("\nQual é o nome da nova pessoa?: ");
    DateTime dataNasc = DateTimeE($"\nQuando nasceu {nome}? (dd/mm/yyyy): ", "dd/MM/yyyy");

    return new(nome, dataNasc);
}

string String(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write(enunciado);
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
            return texto.Trim();

        Console.WriteLine("\n\tValor invalido!!!!!! Tente novamente");
    }
}

DateTime DateTimeE(string enunciado, string formato)
{
    while (true)
    {
        Console.Write(enunciado);
        if (System.DateTime.TryParseExact(Console.ReadLine(), formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            return data;

        Console.WriteLine("\nData inválida!!!! Tente novamente");
    }
}

bool DesejaContinuar(string enunciado)
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

        Console.WriteLine("\nDecisão inválida!!!!! É SIM/NÃO!!!");
    }
}

bool Validacion(Pessoa pessoa)
{
    if(pessoa.DataNascimento.Month != DateTime.Now.Month) 
        return false;

    if(pessoa.DataNascimento.Day != DateTime.Now.Day) 
        return false;

    return true;
}