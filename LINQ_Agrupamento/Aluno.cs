namespace LINQ_Agrupamento;

public sealed class Aluno
{
    public int AlunoId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public char Sexo { get; set; }
    public string? Curso { get; set; }
    public int Idade { get; set; }
}