namespace LINQ_Conjuntos;

public class FonteDados
{
    public static int[] GetIdades()
    {
        var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };
        return idades;
    }

    public static string[] GetNomes()
    {
        var nomes = new[] { "Paulo", "MARIA", "Amanda", "maria", "amanda" };
        return nomes;
    }

    public static List<int> GetNumeros()
    {
        List<int> numeros = new List<int>()
        {
            1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096
        };
        return numeros;
    }

    public static List<int> GetListaNegra()
    {
        List<int> numeros = new List<int>()
        {
            16, 128, 512
        };
        return numeros;
    }

    public static string[] GetPaises()
    {
        string[] paises = { "Brasil", "USA", "UK", "Argentina", "China" };
        return paises;
    }

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 42 },
            new Aluno() { Nome = "Isabel", Idade = 42 },
            new Aluno() { Nome = "Manoel", Idade = 34 },
            new Aluno() { Nome = "Amanda", Idade = 21 },
            new Aluno() { Nome = "Carlos", Idade = 18 },
            new Aluno() { Nome = "Alicia", Idade = 15 },
            new Aluno() { Nome = "Jaime", Idade = 18 },
        };
        return alunos;
    }

    public static List<Aluno> GetTurmaA()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 36, Nascimento = new DateTime(2001, 6, 11) },
            new Aluno() { Nome = "Isabel", Idade = 33, Nascimento = new DateTime(2000, 2, 10) },
            new Aluno() { Nome = "Manoel", Idade = 34, Nascimento = new DateTime(1986, 9, 30) },
            new Aluno() { Nome = "Amanda", Idade = 21, Nascimento = new DateTime(1999, 10, 11) },
            new Aluno() { Nome = "Carlos", Idade = 18, Nascimento = new DateTime(1988, 9, 15) },
            new Aluno() { Nome = "Alicia", Idade = 15, Nascimento = new DateTime(1994, 1, 31) },
            new Aluno() { Nome = "Jaime", Idade = 18, Nascimento = new DateTime(1993, 8, 10) },
        };
        return alunos;
    }

    public static List<Aluno> GetTurmaB()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Homero", Idade = 36, Nascimento = new DateTime(2001, 6, 11) },
            new Aluno() { Nome = "Silvia", Idade = 33, Nascimento = new DateTime(2000, 2, 10) },
            new Aluno() { Nome = "Patricia", Idade = 34, Nascimento = new DateTime(1986, 9, 30) },
            new Aluno() { Nome = "Felicio", Idade = 21, Nascimento = new DateTime(1999, 10, 11) },
            new Aluno() { Nome = "Carlos", Idade = 18, Nascimento = new DateTime(1988, 9, 15) },
            new Aluno() { Nome = "Alfredo", Idade = 15, Nascimento = new DateTime(1994, 1, 31) },
            new Aluno() { Nome = "Denize", Idade = 18, Nascimento = new DateTime(1993, 8, 10) },
        };
        return alunos;
    }
}