public class Filme
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificacaoIndicativa;

    public string ObterClassificacao()
    {
        if(classificacaoIndicativa <= 0)
        {
            return "livre";

        }
        return classificacaoIndicativa + "anos";
    }
    public void ExibirInformacoes()

    {
        Console.WriteLine("\n=== Filme Cadastrado ===");
        Console.WriteLine($"Nome: {titulo}");
        Console.WriteLine($"Genero: {genero}");
        Console.WriteLine($"Ano que foi lançado:{anoLancamento}");
        Console.WriteLine($"Classificação: {classificacaoIndicativa}");
        Console.WriteLine("Classificação: " + ObterClassificacao());
    }
}