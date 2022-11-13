namespace LINQ_Projecao;

public class Aluno
{
    public string Nome { get; set; } = String.Empty;
    public int Idade { get; set; }
    public int Nota { get; set; }
    public List<string> Cursos { get; set; } = new List<string>();
}
