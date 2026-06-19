using System.Threading.Channels;

Filme filme = new Filme();

int opcao;
do
{
    Console.WriteLine("\n ======CATÁLOGO DE FILME======");
    Console.WriteLine("1 - Cadastrar filme");
    Console.WriteLine("2 - Exibir filme");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opçõo");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Titulo: ");
            filme.titulo = Console.ReadLine();
            Console.Write("Genero: ");
            filme.genero = Console.ReadLine();
            Console.Write("Ano de lançamento: ");
            filme.anoLancamento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classificação Indicativa: ");
            filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFilme cadastrado com sucesso!");
            break;

        case 2:
            if (string.IsNullOrEmpty(filme.titulo))
            {
                Console.WriteLine("\nNenhum filme cadastrado.");
            }
            else
            {
                filme.ExibirInformacoes();
            }
            break;

        case 0:
            Console.WriteLine("\nPrograma encerrado.");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }
} while (opcao != 0);




filme.ExibirInformacoes();