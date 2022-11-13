using System.Data;
using LINQ_Agrupamento;

Console.WriteLine("## Operadores de agrupamento ##\n");

/** GroupBy **/

List<Aluno> alunos = new()
{
    new Aluno() { AlunoId = 1, Curso = "Física", Nome = "Vítor", Sexo = 'M', Idade = 18 },
    new Aluno() { AlunoId = 2, Curso = "Química", Nome = "Jorge", Sexo = 'M', Idade = 21 },
    new Aluno() { AlunoId = 3, Curso = "Engenharia", Nome = "Bernardo", Sexo = 'M', Idade = 18 },
    new Aluno() { AlunoId = 4, Curso = "Moda", Nome = "Danusa", Sexo = 'F', Idade = 19 },
    new Aluno() { AlunoId = 5, Curso = "Moda", Nome = "Carla", Sexo = 'F', Idade = 20 },
    new Aluno() { AlunoId = 6, Curso = "Física", Nome = "Hélio", Sexo = 'M', Idade = 21 },
    new Aluno() { AlunoId = 7, Curso = "Engenharia", Nome = "Bianca", Sexo = 'F', Idade = 19 },
    new Aluno() { AlunoId = 8, Curso = "Química", Nome = "Vilma", Sexo = 'F', Idade = 20 },
    new Aluno() { AlunoId = 9, Curso = "Engenharia", Nome = "Amanda", Sexo = 'F', Idade = 18 },
    new Aluno() { AlunoId = 10, Curso = "Química", Nome = "Silvia", Sexo = 'F', Idade = 21 },
};

// Sintaxe de método
var grupos = alunos.GroupBy(a => a.Idade).OrderBy(a => a.Key);

// Sintaxe de consulta
var grupos2 = from a in alunos
              group a by a.Idade into grupo
              orderby grupo.Key
              select grupo;

// GroupBy com múltiplas chaves
var gruposKeyMultiplas = alunos.GroupBy(a => new { a.Curso, a.Sexo })
    .OrderByDescending(g => g.Key.Curso)
    .ThenBy(g => g.Key.Sexo)
    .Select(g => new {
        Curso = g.Key.Curso,
        Sexo = g.Key.Sexo,
        Alunos = g.OrderBy(x => x.Nome)
    });

// Itera em cada grupo
foreach (var grupo in grupos)
{
    Console.WriteLine($"\nIdade: {grupo.Key} alunos: {grupo.Count()}");
    // Itera através cada aluno do grupo
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Nome} {aluno.Curso} {aluno.Sexo}");
    }
}

/** GroupBy **/

/** ToLookUp **/

// Execução imediata
var gruposToLookUp = alunos.ToLookup(a => a.Curso);

foreach (var grupo in gruposToLookUp)
{
    Console.WriteLine($"\n {grupo.Key} ({grupo.Count()})");
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Nome} {aluno.Idade} {aluno.Sexo}");
    }
}

/** ToLookUp **/

Console.ReadKey();