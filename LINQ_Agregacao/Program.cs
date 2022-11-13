using LINQ_Agregacao;

Console.WriteLine("## Operadores de Agregação ##\n");

/** Aggregate **/

string[] cursos = { "C#", "Java", "Python", "PHP", "JavaScript", "GO" };

string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);

Console.WriteLine(resultado);

int[] numeros = { 3, 5, 7, 9, 11, 12, 13, 14, 15 };

int resultado2 = numeros.Aggregate((n1, n2) => n1 * n2);

Console.WriteLine(resultado2);

// Aggregate com valor de semente inicial
List<Aluno> alunos = new()
{
    new Aluno() { Nome = "Maria", Idade = 22 },
    new Aluno() { Nome = "Manoel", Idade = 25 },
    new Aluno() { Nome = "Amanda", Idade = 21 },
    new Aluno() { Nome = "Juliana", Idade = 18 },
};

string listaAlunos = alunos.Aggregate<Aluno, string>("Nomes: ", //valor semente 
    (semente, aluno) => semente += aluno.Nome + ", ");

// Remove a virgula do final da lista
int indice = listaAlunos.LastIndexOf(",");
listaAlunos = listaAlunos.Remove(indice);

Console.WriteLine(listaAlunos);

// Aggregate com valor de semente inicial e seletor de resultado
string listaAlunos2 = alunos.Aggregate<Aluno, string, string>("Nomes: ", //valor semente
    (semente, aluno) => semente += aluno.Nome + ", ", resultado => resultado.Substring(0, resultado.Length-2));

Console.WriteLine(listaAlunos2);

/** Aggregate **/

/** Average **/

var mediaIdades = alunos.Average(aluno => aluno.Idade);

Console.WriteLine($"Média das idades: {mediaIdades} anos ");

/** Average **/

/** Count **/

var numeroCursos = cursos.Count();

Console.WriteLine($"Número de cursos: {numeroCursos}");

// Count com filtro
var resultadoCount = cursos.Count(c => c.Contains('P'));
var resultadoCount2 = cursos.Where(c => c.Contains('P')).Count();

// Sintaxe de consulta
var resultadoCount3 = (from c in cursos
                        where c.Contains('P')
                        select c).Count();

Console.WriteLine($"Count com filtro: {resultadoCount3}");

/** Count **/

/** LongCount **/

var numeroCursos2 = cursos.LongCount();

Console.WriteLine($"Número de cursos: {numeroCursos2}");

// Count com filtro
var resultadoLongCount = cursos.LongCount(c => c.Contains('P'));
var resultadoLongCount2 = cursos.Where(c => c.Contains('P')).LongCount();

// Sintaxe de consulta
var resultadoLongCount3 = (from c in cursos
                        where c.Contains('P')
                        select c).LongCount();

Console.WriteLine($"LongCount com filtro: {resultadoLongCount3}");

/** LongCount **/

/** Sum **/

int resultadoSum = numeros.Sum();

Console.WriteLine($"Resultado Método Sum: {resultadoSum}");

// Sum com filtro
var resultadoSumComFiltro = numeros.Where(n => n > 10).Sum();

Console.WriteLine($"Resultado Método Sum com filtro: {resultadoSumComFiltro}");

int resultadoSum2 = numeros.Sum(n => 
{
    if (n > 10)
        return n;
    else
        return 0;
});

Console.WriteLine($"Resultado Método Sum2: {resultadoSum2}");

/** Sum **/

/** Max ou MaxBy **/

List<Funcionario> funcionarios = new()
{
    new Funcionario() { Nome = "Maria", Idade = 36, Salario = 3850.00m },
    new Funcionario() { Nome = "Manoel", Idade = 33, Salario = 2490.00m },
    new Funcionario() { Nome = "Amanda", Idade = 29, Salario = 1850.00m },
    new Funcionario() { Nome = "Debora", Idade = 21, Salario = 5240.50m },
    new Funcionario() { Nome = "Jose", Idade = 45, Salario = 10280.00m },
    new Funcionario() { Nome = "Raul", Idade = 18, Salario = 1650.00m },
};

var resultadoMaxIdade = funcionarios.Max(p => p.Idade);
var resultadoMaxSalario = funcionarios.Max(p => p.Salario);

var valorMaximo = funcionarios.Max(f => 
{
    if (f.Idade > 30)
        return f.Salario;
    else
        return 0;
});

Console.WriteLine($"Valor máximo idade acima de 30: {valorMaximo}");

Console.WriteLine($"Resultado método Max: {resultadoMaxIdade} Idade maior e Salário maior {resultadoMaxSalario}");

/** Max ou MaxBy **/

/** Min ou MinBy **/

var resultadoMinIdade = funcionarios.Min(p => p.Idade);
var resultadoMinSalario = funcionarios.Min(p => p.Salario);

var valorMinimo = funcionarios.Where(f => f.Idade < 20).Min(p => p.Salario);

Console.WriteLine($"Valor minimo idade menor de 20: {valorMinimo}");

Console.WriteLine($"Resultado método Min: {resultadoMinIdade} Idade menor e Salário menor {resultadoMinSalario}");

/** Min ou MinBy **/

Console.ReadKey();