using LINQ_Projecao;

Console.WriteLine("## LINQ - Operadores de Projeção ##\n");

/** LINQ - SELECT **/

// Sintaxe de método
IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();

Console.WriteLine("Alunos | Idade | Nota\n");
foreach (var aluno in alunos)
{
    Console.WriteLine($"{aluno.Nome} : {aluno.Idade} : {aluno.Nota}");
}
Console.WriteLine("\n");

IEnumerable<string> nomes = FonteDados.GetAlunos().Select(n => n.Nome);

Console.WriteLine("Alunos\n");
foreach (var nome in nomes)
{
    Console.WriteLine($"{nome}");
}
Console.WriteLine("\n");

List<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
{
    Nome = a.Nome,
    Idade = a.Idade
}).ToList();

Console.WriteLine("Alunos | Idade\n");
foreach (var aluno in lista)
{
    Console.WriteLine($"{aluno.Nome} | {aluno.Idade}");
}
Console.WriteLine("\n");

var alunosTipoAnonimo = FonteDados.GetAlunos().Select(a => new
{
    NomeAluno = a.Nome,
    IdadeAluno = a.Idade,
    NotaAluno = a.Nota
}).ToList();

Console.WriteLine("Alunos | Idade\n");
foreach (var aluno in alunosTipoAnonimo)
{
    Console.WriteLine($"{aluno.NomeAluno} | {aluno.IdadeAluno}");
}
Console.WriteLine("\n");

var funcionarios = FonteDados.GetFuncionarios().Select(f => new
{
    Nome = f.Nome,
    Idade = f.Idade,
    SalarioAnual = f.Salario * 12
}).ToList();

Console.WriteLine("Funcionarios | Idade | Salario Anual\n");
foreach (var funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome} | {funcionario.Idade} | {funcionario.SalarioAnual.ToString("c")}");
}
Console.WriteLine("\n");

/** LINQ - SELECT **/

/** LINQ - SELECTMANY **/

List<List<int>> listas = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 12 },
    new List<int> { 5, 6, 5, 7 },
    new List<int> { 10, 12, 12, 13 },
};

IEnumerable<int> resultado = listas.SelectMany(lista => lista.Distinct());
foreach (var i in resultado)
    Console.Write($"{i} ");

/** LINQ - SELECTMANY **/

Console.ReadKey();

