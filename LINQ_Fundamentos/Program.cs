using LINQ_Fundamentos;

Console.WriteLine("## LINQ - Filtrar Dados ##\n");

// numeros = 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096
var numeros = FonteDados.GetNumeros();

var resultado1 = numeros.Where(n => n < 10);

var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

// 16, 128, 512
var listaNegra = FonteDados.GetListaNegra();

var resultado3 = numeros.Where(n => !listaNegra.Contains(n));

// Execução adiada e avaliação lenta
var resultado4 = numeros.Where(n => n > 1)
                        .Where(n => n != 4)
                        .Where(n => n < 20);

Console.WriteLine(string.Join(" ", resultado4));

// trabalhar com objetos complexos
var alunos = FonteDados.GetAlunos();

var resultado5 = alunos.Where(a => a.Nome.StartsWith('A') && a.Idade < 18);

// Sintaxe de consulta
var filtro = from a in alunos
             where a.Nome.StartsWith('A') && a.Idade < 18
             select a;

foreach (var aluno in resultado5)
{
    Console.WriteLine($"{aluno.Nome} : {aluno.Idade}");
}

Console.ReadKey();
