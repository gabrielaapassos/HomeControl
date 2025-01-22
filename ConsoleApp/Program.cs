using System;

namespace HomeControl.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Controle de Estoque Doméstico ===");
                Console.WriteLine("1. Adicionar Item ao Estoque");
                Console.WriteLine("2. Atualizar Quantidade de Item");
                Console.WriteLine("3. Registrar Consumo de Item");
                Console.WriteLine("4. Gerar Relatório de Consumo");
                Console.WriteLine("5. Gerar Relatório de Estoque Baixo");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarItem();
                        break;
                    case "2":
                        AtualizarQuantidade();
                        break;
                    case "3":
                        RegistrarConsumo();
                        break;
                    case "4":
                        GerarRelatorioConsumo();
                        break;
                    case "5":
                        GerarRelatorioEstoqueBaixo();
                        break;
                    case "6":
                        Console.WriteLine("Saindo do sistema...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AdicionarItem(DataContext context)
        {
            Console.Clear();
            Console.WriteLine("=== Adicionar Item ao Estoque ===");

            // Obter os dados do usuário
            Console.Write("Nome do item: ");
            var nome = Console.ReadLine();

            Console.Write("Categoria do item: ");
            var categoria = Console.ReadLine();

            Console.Write("Quantidade inicial: ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade))
            {
                Console.WriteLine("Quantidade inválida!");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
            }

            Console.Write("Data de Validade (opcional, formato: AAAA-MM-DD): ");
            var validadeInput = Console.ReadLine();
            DateTime? validade = string.IsNullOrWhiteSpace(validadeInput) ? null : DateTime.Parse(validadeInput);

            // Criar o objeto ItemEstoque
            var item = new ItemEstoque
            {
                Nome = nome,
                Categoria = categoria,
                Quantidade = quantidade,
                DataAdicao = DateTime.Now,
                DataValidade = validade
            };

            // Salvar no banco de dados
            try
            {
                context.Add(item);
                context.SaveChanges();
                Console.WriteLine("Item adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar o item: {ex.Message}");
            }

            // Confirmar e voltar ao menu
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


        static void AtualizarQuantidade()
        {
            Console.Clear();
            Console.WriteLine("=== Atualizar Quantidade de Item ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.ReadKey();
        }

        static void RegistrarConsumo()
        {
            Console.Clear();
            Console.WriteLine("=== Registrar Consumo de Item ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.ReadKey();
        }

        static void GerarRelatorioConsumo()
        {
            Console.Clear();
            Console.WriteLine("=== Gerar Relatório de Consumo ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.ReadKey();
        }

        static void GerarRelatorioEstoqueBaixo()
        {
            Console.Clear();
            Console.WriteLine("=== Gerar Relatório de Estoque Baixo ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.ReadKey();
        }
    }
}
