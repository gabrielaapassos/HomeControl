using HomeControl.Business.Services;
using HomeControl.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace HomeControl.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configurar o DbContext
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlite("Data Source=HomeControl.db")
                .Options;

            using var context = new DataContext(options);

            // Inicializar o ItemService
            var itemService = new ItemService(context);

            // Menu principal
            MenuPrincipal(itemService);
        }
        
        static void MenuPrincipal(ItemService itemService) { 

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
                        AdicionarItem(itemService);
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

        static void AdicionarItem(ItemService itemService)
        {
            Console.Clear();
            Console.WriteLine("=== Adicionar Item ao Estoque ===");

            Console.Write("Nome do item: ");
            var nome = Console.ReadLine();

            Console.Write("Categoria do item: ");
            var categoria = Console.ReadLine();

            Console.Write("Quantidade inicial: ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade))
            {
                Console.WriteLine("Quantidade inválida!");
                Console.ReadKey();
                return;
            }

            Console.Write("Data de Validade (opcional, formato: AAAA-MM-DD): ");
            var validadeInput = Console.ReadLine();
            DateTime? validade = string.IsNullOrWhiteSpace(validadeInput) ? null : DateTime.Parse(validadeInput);

            itemService.AdicionarItem(nome, categoria, quantidade, validade);

            Console.WriteLine("Item adicionado com sucesso!");
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
