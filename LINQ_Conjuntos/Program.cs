using LINQ_Conjuntos;

Console.WriteLine("## LINQ - Operações com conjuntos ## \n");

/** Distinct ou DistinctBy **/

Console.WriteLine("idades -> 30, 33, 35, 36, 40, 30, 33, 36, 30, 40");

var idadesDistintas = FonteDados.GetIdades().Distinct();

foreach (var idade in idadesDistintas)
{
    Console.Write($"{idade} ");
}

Console.WriteLine("nomes -> Paulo, MARIA, Amanda, maria, amanda");

var nomesDistintos = FonteDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);

foreach (var nome in nomesDistintos)
{
    Console.Write($"{nome} ");
}

var alunos = FonteDados.GetAlunos().ToList();

var alunosIdadesDistintas = alunos.DistinctBy(a => a.Idade);

foreach (var aluno in alunosIdadesDistintas)
{
    Console.WriteLine($"Aluno {aluno.Nome} tem {aluno.Idade} anos.");
}

/** Distinct ou DistinctBy **/

/** Except ou ExceptBy **/

List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultado = fonte1.Except(fonte2).ToList();

foreach (var item in resultado)
{
    Console.Write($"{item} ");
}

List<string> paises1 = new List<string>() { "Brasil", "UK", "USA", "Argentina", "China", "Canadá" };
List<string> paises2 = new List<string>() { "Brasil", "uk", "usa", "Argentina", "China", "Cuba" };

var resultadoPaises = paises1.Except(paises2, StringComparer.OrdinalIgnoreCase).ToList();

foreach (var item in resultadoPaises)
{
    Console.Write($"{item} ");
}

//var alunos = FonteDados.GetAlunos();

var alunosReprovados = new List<string>() { "Amanda", "Alicia", "Jaime" };

var alunosAprovados = alunos.ExceptBy(alunosReprovados, n => n.Nome);

Console.WriteLine("Alunos Aprovados\n");
foreach (var aluno in alunosAprovados)
{
    Console.WriteLine($"{aluno.Nome} ");
}

/** Except ou ExceptBy **/

/** Intersect ou IntersectBy **/

List<int> fonte3 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte4 = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultadoIntersect = fonte1.Intersect(fonte4).ToList();

foreach (var item in resultadoIntersect)
{
    Console.Write($"{item} ");
}

List<string> paises3 = new List<string>() { "Brasil", "USA", "UK", "Argentina", "China" };
List<string> paises4 = new List<string>() { "Brasil", "uk", "Argentina", "França", "Japão" };

var resultadoIntersectPaises = paises3.Intersect(paises4, StringComparer.OrdinalIgnoreCase).ToList();

foreach (var item in resultadoIntersectPaises)
{
    Console.Write($"{item} ");
}

var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();

var resultadoIntersectBy = turmaA.Select(p => p.Nascimento.Year)
    .Intersect(turmaB.Select(p => p.Nascimento.Year));

var alunosTurmaAComMesmoAnoNascimento = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento.Year), p => p.Nascimento.Year);

Console.WriteLine("Turma A - Alunos com mesmo ano de nascimento da Turma B\n");

foreach (var aluno in alunosTurmaAComMesmoAnoNascimento)
{
    Console.WriteLine($"{aluno.Nome} ");
}
Console.WriteLine($"\nTotal de Alunos: {alunosTurmaAComMesmoAnoNascimento.Count()}");

/** Intersect ou IntersectBy **/

/** Union ou UnionBy **/

List<int> fonte5 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonte6 = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultadoUnion = fonte5.Union(fonte6).ToList();

foreach (var item in resultadoUnion)
{
    Console.Write($"{item} ");
}

List<string> paises5 = new List<string>() { "Brasil", "USA", "UK", "Argentina", "China" };
List<string> paises6 = new List<string>() { "Brasil", "uk", "Argentina", "França", "Japão" };

var resultadoUnionPaises = paises5.Union(paises6, StringComparer.OrdinalIgnoreCase).ToList();

foreach (var pais in resultadoUnionPaises)
{
    Console.Write($"{pais} ");
}

var consultaUnion = turmaA.Select(p => p.Nome).Union(turmaB.Select(p => p.Nome));

var turmasUnionBy = turmaA.UnionBy(turmaB, p => p.Nome);

Console.WriteLine("Alunos nomes distintos\n");

foreach (var aluno in turmasUnionBy)
{
    Console.WriteLine($"{aluno.Nome} {aluno.Nascimento.Year} {aluno.Idade}");
}

/** Union ou UnionBy **/

Console.ReadKey();
