using System.Threading.Channels;

Filme filme = new Filme();

Console.Write("Titulo: ");
filme.titulo = Console.ReadLine();
Console.Write("Genero: " );
filme.genero = Console.ReadLine();
Console.Write("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());
Console.Write("Classificação Indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();