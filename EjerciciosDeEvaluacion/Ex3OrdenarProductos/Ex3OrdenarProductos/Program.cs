/*Exercício 3: Ordenação de Produtos:

Dada uma lista de objetos do tipo Produto (com propriedades Nome e Preço), utilize LINQ para ordenar os produ-
tos por preço em ordem decrescente.*/

using Ex3OrdenarProductos.Entities;
using System.Globalization;

List<Produto> produtos;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 3 - Tutorial 11");

    produtos = new();

    do
    {
        produtos.Add(Produto());
    } while (DesejaContinuar("Deseja acrescentar outro produto"));

    produtos = [.. produtos.OrderByDescending(x => x.Precio)];

    Console.WriteLine("\nProdutos organizados: \n");

    foreach(Produto produto in produtos)
        Console.WriteLine("\t" + produto.ToString());

} while (DesejaContinuar("Deseja inserir uma nova lista de produtos"));

Produto Produto()
{
    string nome = String("\nNome do produto: ");
    double preco = Double("\nPreço do produto: ");

    return new(nome, preco);
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

double Double(string enunciado)
{
    while (true)
    {
        Console.Write(enunciado);
        if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double result) && result >= 0)
            return result;

        Console.WriteLine("\nNúmero inválida!!!! Tente novamente");
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