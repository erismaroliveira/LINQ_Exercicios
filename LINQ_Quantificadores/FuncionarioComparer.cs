using System.Diagnostics.CodeAnalysis;

namespace LINQ_Quantificadores;

public class FuncionarioComparer : IEqualityComparer<Funcionario>
{
    // Funcionários são iguais se os nomes e os pontos forem iguais
    public bool Equals(Funcionario? x, Funcionario? y)
    {
        // Se ambas referências dos objetos forem iguais retorna true
        if (object.ReferenceEquals(x, y))
            return true;

        // Se uma das referências for null retorna false
        if (x is null || y is null)
            return false;

        return x.Nome == y.Nome && x.Pontos == y.Pontos;
    }

    // Se Equals() retornar true para o par de objetos
    // GetHashCode() tem que retornar os mesmos valores para os objetos
    public int GetHashCode([DisallowNull] Funcionario obj)
    {
        // Se o objeto for null retorna 0
        if (obj is null)
            return 0;
        
        int NomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
        int PontosHashCode = obj.Pontos.GetHashCode();

        return NomeHashCode ^ PontosHashCode;
    }
}
