/*Exercício 4: Contagem de Caracteres Únicos:
Dada uma string, utilize LINQ para contar quantos caracteres únicos estão presentes.*/

using System.Globalization;

string palavra, mensaje;
int numCaracteres;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 4 - Tutorial 14");

    palavra = String("\nQual palavra deseja inserir?: ");

    numCaracteres = palavra.GroupBy(c => c).Count();

    mensaje = numCaracteres == 1 ? "caracter ordenado é " : "caracteres ordenadas são ";

    Console.WriteLine($"\nNúmero de {mensaje} {numCaracteres} \n");

} while (Deseja());

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

        Console.WriteLine("\n\tPalabra invalida!!!!!! Tente novamente");
    }
}

bool Deseja()
{
    string? texto;

    while (true)
    {
        Console.Write($"\nDeseja inserir outra lista de palavras? Sim/Não: ");
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