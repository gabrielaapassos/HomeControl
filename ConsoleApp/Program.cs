﻿using HomeControl.Business.Services;
using HomeControl.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Models.Items;

using System;

namespace HomeControl.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlite("Data Source=HomeControl.db")
                .Options;

            using var context = new DataContext(options);

            var itemService = new ItemService(context);

            var categoriaService = new CategoriaService(context);

            MenuPrincipal(itemService,categoriaService);
        }
        
        static void MenuPrincipal(ItemService itemService, CategoriaService categoriaService) { 

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Controle de Estoque Doméstico ===");
                Console.WriteLine("1. Adicionar Item ao Estoque");
                Console.WriteLine("2. Atualizar Quantidade de Item");
                Console.WriteLine("3. Registrar Consumo de Item");
                Console.WriteLine("4. Mostrar Itens Cadastrados");
                Console.WriteLine("5. Remover Item do Estoque");
                Console.WriteLine("6. Gerar Relatório de Consumo");
                Console.WriteLine("7. Gerar Relatório de Estoque Baixo");
                Console.WriteLine("8. Gerenciar Categorias");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        Console.WriteLine("Saindo do sistema...");
                        running = false;
                        break;
                    case "1":
                        AdicionarItem(itemService,categoriaService);
                        break;
                    case "2":
                        AtualizarQuantidade();
                        break;
                    case "3":
                        RegistrarConsumo();
                        break;
                    case "4":
                        BuscarItens(itemService);
                        break;
                    case "5":
                        RemoverItem(itemService);
                        break;
                    case "6":
                        GerarRelatorioConsumo();
                        break;
                    case "7":
                        GerarRelatorioEstoqueBaixo();
                        break;
                    case "8":
                        CategoriaConsole.MenuCategoria(categoriaService);
                        break;
                    case "9":
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AdicionarItem(ItemService itemService,CategoriaService categoriaService)
        {
            Console.Clear();
            Console.WriteLine("=== Adicionar Item ao Estoque ===");

            Console.Write("Nome do item: ");
            var nome = Console.ReadLine();

            CategoriaConsole.MostrarCategorias(categoriaService);

            Console.Write("Selecione o Id da categoria a qual o item se encaixa:");
            if (!int.TryParse(Console.ReadLine(), out int idCategoria))
            {
                Console.WriteLine("Quantidade inválida!");
                Console.ReadKey();
                return;
            }
            var categoria = categoriaService.PegaCategoria(idCategoria);
            


            Console.Write("Quantidade inicial: ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade))
            {
                Console.WriteLine("Quantidade inválida!");
                Console.ReadKey();
                return;
            }

            Console.Write("Unidade de medida do item (ex: litros,unidades,quilos): ");
            var unidadeMedida = Console.ReadLine();

            Console.Write("Data de Validade (opcional, formato: AAAA-MM-DD): ");
            var validadeInput = Console.ReadLine();
            DateTime? validade = string.IsNullOrWhiteSpace(validadeInput) ? null : DateTime.Parse(validadeInput);

            itemService.AdicionarItem(nome, categoria, quantidade, validade, unidadeMedida);

            Console.WriteLine($"{quantidade} {unidadeMedida} de {nome}, Vencimento: {validade} adicionado com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RemoverItem(ItemService itemService)
        {
            Console.Clear();
            Console.WriteLine("=== Remover Item do Estoque ===");

            Console.Write("Id do item: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id inválido!");
                Console.ReadKey();
                return;
            }

            var item = itemService.RemoveItem(id);
            if (item != null)
            {
                Console.WriteLine($"{item.Quantidade} {item.UnidadeMedida} de {item.Nome}, Vencimento: {item.Validade} removido com sucesso!");
            }else
            {
                Console.WriteLine("item não encontrado");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }


        static void AtualizarQuantidade()
        {
            Console.Clear();
            Console.WriteLine("=== Atualizar Quantidade de Item ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void RegistrarConsumo()
        {
            Console.Clear();
            Console.WriteLine("=== Registrar Consumo de Item ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void GerarRelatorioConsumo()
        {
            Console.Clear();
            Console.WriteLine("=== Gerar Relatório de Consumo ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void GerarRelatorioEstoqueBaixo()
        {
            Console.Clear();
            Console.WriteLine("=== Gerar Relatório de Estoque Baixo ===");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void BuscarItens(ItemService itemService)
        {
            Console.Clear();
            Console.WriteLine("=== Itens Cadastrados no estoque ===");
            List<ItemEstoque> itensCadastrados = itemService.BuscarItens();
            foreach (ItemEstoque item in itensCadastrados)
            {
                Console.WriteLine($"Id: {item.Id},Voce tem {item.Quantidade} {item.UnidadeMedida} de {item.Nome}, Vencimento: {item.Validade}");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
