namespace AnaliseDeRecursosHumanos;

class Program
{
    static void Main(string[] args)
    {
        // Leitura da entrada do usuário
        string? input = Console.ReadLine();

        // Processamento da entrada
        List<string> departamentos = input!.Split(',').ToList();

        // Contagem de funcionários por departamento
        Dictionary<string, int> contagemDepartamentos = ContarFuncionariosPorDepartamento(departamentos);

        // Formatação da saída
        var resultado = string.Join(Environment.NewLine,
                                    contagemDepartamentos.OrderBy(depto => depto.Key)
                                                         .Select(depto => $"{depto.Key}: {depto.Value}"));

        Console.WriteLine(resultado);
    }
    static Dictionary<string, int> ContarFuncionariosPorDepartamento(List<string> departamentos)
    {
        var contagem = new Dictionary<string, int>();
        departamentos.ForEach(d =>
        {
            if (!contagem.TryAdd(d, 1)) contagem[d] += 1;
        });
        return contagem;
    }
}