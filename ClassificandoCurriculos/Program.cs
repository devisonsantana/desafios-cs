namespace ClassificandoCurriculos;

class Program
{
    static void Main(string[] args)
    {
        // Leitura da entrada do usuário
        string input = Console.ReadLine();

        // Processamento da entrada
        List<int> anosExperiencia = input.Split(',')
                                          .Select(x => int.Parse(x))
                                          .ToList();

        // Classificação dos currículos
        List<string> classificacoes = ClassificarCurriculos(anosExperiencia);

        // Formatação da saída
        string resultado = string.Join(", ", classificacoes);
        Console.WriteLine(resultado);
    }
    static List<string> ClassificarCurriculos(List<int> anosExperiencia)
    {
        List<string> classificados = [];

        // TODO: Itere sobre cada número de anos de experiência na lista 'anosExperiencia' e preencha a lista de classificações.
        classificados = [.. anosExperiencia.Select(exp =>
        {
            if(exp <= 3) return "Junior";
            else if (exp > 3 && exp <= 5) return "Pleno";
            else return "Senior";
        })];
        return classificados;
    }
}
