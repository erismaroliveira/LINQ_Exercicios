using LINQ_Quantificadores;

Console.WriteLine("## Operadores de quantificação ##\n");

/** All **/

int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };

var resultado = numeros.All(n => n % 2 == 0);

Console.WriteLine($"{(resultado ? "Todos são pares" : "Nem todos são pares")}");

List<Funcionario> funcionarios = new()
{
    new Funcionario() { Nome = "Marcos", Idade = 22, Salario = 2600.00m },
    new Funcionario() { Nome = "Mateus", Idade = 25, Salario = 2560.00m },
    new Funcionario() { Nome = "Allan Steven", Idade = 23, Salario = 5850.00m },
};

var todosSalariosAcima2500 = funcionarios.All(f => f.Salario > 2500.00m);
var todosMaiorQue21 = funcionarios.All(f => f.Idade > 21);
var todosNomesContemLetraA = funcionarios.All(f => f.Nome.Contains('a'));

Console.WriteLine($"{todosSalariosAcima2500} - {todosMaiorQue21} - {todosNomesContemLetraA}");

List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa() { Nome = "Maria", Cachorros = new Cachorro[] { new Cachorro { Nome = "Bilu", Idade = 10 }, new Cachorro { Nome = "Tiziu", Idade = 7 }, new Cachorro { Nome = "Romeu", Idade = 3 } } },
    new Pessoa() { Nome = "Natália", Cachorros = new Cachorro[] { new Cachorro { Nome = "Bill", Idade = 14 } } },
    new Pessoa() { Nome = "Erismar", Cachorros = new Cachorro[] { new Cachorro { Nome = "Bruce Wayne", Idade = 8 }, new Cachorro { Nome = "Negro Drama", Idade = 5 }, new Cachorro { Nome = "Percival", Idade = 3 } } },
};

var nomes = from pessoa in pessoas
            where pessoa.Cachorros.All(pet => pet.Idade > 5)
            select pessoa.Nome;

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

/** All **/

/** Any **/

string[] cursos = { "C#", "Java", "Python", "PHP", "ASP.NET", "Node" };

var existeCursos = cursos.Any();

var existeCursosMaiorQue2 = cursos.Any(c => c.Length > 2);

var resultadoAny = (from c in cursos
                    select c).Any(c => c.Contains('P'));

Console.WriteLine($"{existeCursos} - {existeCursosMaiorQue2} - {resultadoAny}");

List<Cachorro> cachorros = new()
{
    new Cachorro() { Nome = "Bilu", Idade = 6, Vacinado = true },
    new Cachorro() { Nome = "Canelinha", Idade = 3, Vacinado = false },
    new Cachorro() { Nome = "Pipoca", Idade = 8, Vacinado = true },
};

// Verifica se existem cachorros com mais de 2 anos e não vacinados
bool naoVacinados = cachorros.Any(c => c.Idade > 2 && c.Vacinado == false);

var resultadoAnyCachorro = (from c in cachorros
                            select c).Any(c => c.Idade > 2 && c.Vacinado == false);

Console.WriteLine($"{(naoVacinados ? "Existem" : "Não existem")} cães com mais de 2 anos não vacinados");

/** Any **/

/** Contains **/

List<Funcionario> funcionariosContains = new List<Funcionario>()
{
    new Funcionario() { Nome = "Maria", Pontos = 275 },
    new Funcionario() { Nome = "Marta", Pontos = 375 },
    new Funcionario() { Nome = "Pedro", Pontos = 299 },
};

FuncionarioComparer funcionarioComparer = new FuncionarioComparer();

var funcionario1 = new Funcionario() { Nome = "Maria", Pontos = 275 };

// False - Objeto referencia | True - Usando a segunda Sobrecarga do método Contains interface IEqualityComparer<Funcionario> 
var resultadoContains = funcionariosContains.Contains(funcionario1, funcionarioComparer);

Console.WriteLine($"{resultadoContains}");

/** Contains **/

Console.ReadKey();