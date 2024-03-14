/*Dada uma lista de objetos do tipo Produto, utilize LINQ para selecionar e imprimir os produtos cujo preço seja su-
perior a um valor determinado.*/

using Ex07ProductosLimitePrecio.Entities;
using System.Globalization;

List<Producto> produtos;
double minimo;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 7 - Tutorial 11");

    produtos = new();

    do
    {
        produtos.Add(Produto());
    } while (DesejaContinuar("Deseja acrescentar outro produto"));

    minimo = Double("\nDesde que valor deseja filtrar os produtos inseridos?: ");

    produtos = [.. produtos.Where(x => x.Precio >= minimo)];

    Console.WriteLine($"\nProdutos filtrados por {minimo}: \n");

    foreach (Producto produto in produtos)
        Console.WriteLine("\t" + produto.ToString());

} while (DesejaContinuar("Deseja inserir uma nova lista de produtos"));

Producto Produto()
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
