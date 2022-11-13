using LINQ_Ordenacao;

Console.WriteLine("## Operadores de Ordenação ##\n");

/** OrderBy ou OrderByDescending, ThenBy ou ThenByDescending **/

List<string> nomes = new List<string>() { "Paulo", "Tarcisio", "Amaral", "Pedro", "Debora", "Helena", "Percival", "Manoel", "Rute", "Jose" };

var lista = nomes.OrderByDescending(nome => nome);

foreach (var nome in lista)
{
    Console.WriteLine(nome + " ");
}

Console.WriteLine("\n");

List<Aluno> alunos = new()
{
    new Aluno() { Nome = "Maria", Idade = 20 },
    new Aluno() { Nome = "Manoel", Idade = 22 },
    new Aluno() { Nome = "Miriam", Idade = 21 },
    new Aluno() { Nome = "Matilda", Idade = 34 },
    new Aluno() { Nome = "Marcos", Idade = 34 },
};

var resultadoOrderBy = alunos.OrderBy(a => a.Nome);

// Ordenar com várias propriedades
var resultadoOrderByThenBy = alunos.OrderBy(a => a.Nome).ThenBy(a => a.Idade);

var resultadoOrderByDescendingThenByDescending = alunos.OrderByDescending(a => a.Nome).ThenByDescending(a => a.Idade);

// Ordenação com filtro
var resultadoWhereOrderByThenBy = alunos
    .Where(a => a.Nome.Contains('r'))
    .OrderBy(a => a.Nome)
    .ThenBy(a => a.Idade);

foreach (var aluno in resultadoWhereOrderByThenBy)
{
    Console.WriteLine($"{aluno.Nome} | {aluno.Idade}");
}

/** OrderBy ou OrderByDescending, ThenBy ou ThenByDescending **/

/** Reverse **/

int[] numeros = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };

var listaReverse = numeros.Reverse();

foreach (var item in listaReverse)
{
    Console.Write($"{item} ");
}

List<string> nomesReverse = new List<string>() { "Pedro", "Tania", "Amaral", "Penita", "Debora" };

//var listaNome = nomesReverse.Reverse(); // Errado! este é um método que retorna void.
nomesReverse.Reverse();

foreach (var nome in nomesReverse)
    Console.Write($"{nome} ");

// Conversão para uso do método Reverse() do namespace System.Linq
IEnumerable<string> lista1 = nomesReverse.AsEnumerable().Reverse();
IQueryable<string> lista2 = nomesReverse.AsQueryable().Reverse();

foreach (var item in lista1)
    Console.Write($"{item} ");

/** Reverse **/

Console.ReadKey();