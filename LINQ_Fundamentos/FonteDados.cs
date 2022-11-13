namespace LINQ_Fundamentos;

public class FonteDados
{
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

    //public static string[] GetPaises()
    //{

    //}

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 42 },
            new Aluno() { Nome = "Manoel", Idade = 34 },
            new Aluno() { Nome = "Amanda", Idade = 21 },
            new Aluno() { Nome = "Carlos", Idade = 18 },
            new Aluno() { Nome = "Alicia", Idade = 15 },
        };
        return alunos;
    }
}