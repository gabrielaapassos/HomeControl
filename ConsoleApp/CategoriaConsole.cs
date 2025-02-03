using HomeControl.Business.Services;
using Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeControl.UI.ConsoleApp
{
    public static class CategoriaConsole
    {
        public static void MenuCategoria(CategoriaService categoriaService)
        {

            bool running = true;

            while (running)
            {
                MostrarCategorias(categoriaService);
                Console.WriteLine();
                Console.WriteLine("=== Sistema de Controle de Estoque Doméstico ===");
                Console.WriteLine("1. Adicionar Categoria ao Sistema");
                Console.WriteLine("2. Remover Categoria do Sistema");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha uma opção: ");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        Console.WriteLine("Saindo do sistema...");
                        running = false;
                        break;
                    case "1":
                        AdicionarCategoria(categoriaService);
                        break;
                    case "2":
                        RemoverCategoria(categoriaService);
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void AdicionarCategoria(CategoriaService categoriaService)
        {
            Console.Clear();
            Console.WriteLine("=== Adicionar Categoria ao Sistema ===");

            Console.Write("Nome da Categoria: ");
            var nome = Console.ReadLine();

            Console.Write("Descricao da Categoria: ");
            var descricao = Console.ReadLine();

            categoriaService.AdicionarCategoria(nome, descricao);

            Console.WriteLine($"Categoria {nome}, Descrita como: {descricao} adicionada com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }


        static void RemoverCategoria(CategoriaService categoriaService)
        {
            Console.WriteLine();
            Console.WriteLine("=== Remover Categoria do Sistema ===");

            Console.Write("Id da Categoria: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id inválido!");
                Console.ReadKey();
                return;
            }

            var categoria = categoriaService.RemoveCategoria(id);
            if (categoria != null)
            {
                Console.WriteLine($"Categoria {categoria.Nome}, Descrita como: {categoria.Descricao} removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void MostrarCategorias(CategoriaService categoriaService)
        {
            Console.Clear();
            Console.WriteLine("=== Categorias Cadastradas no Sistema ===");
            List<Categoria> categoriasCadastradas = categoriaService.BuscarCategorias();
            foreach (Categoria categoria in categoriasCadastradas)
            {
                Console.WriteLine($"Id: {categoria.Id},Categoria {categoria.Nome}, Descrita como: {categoria.Descricao}");
            }
        }
    }
}
