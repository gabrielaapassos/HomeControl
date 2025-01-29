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
                Console.Clear();
                Console.WriteLine("=== Sistema de Controle de Estoque Doméstico ===");
                Console.WriteLine("1. Adicionar Categoria ao Sistema");
                Console.WriteLine("2. Mostrar Categorias Cadastradas");
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
                        BuscarCategorias(categoriaService);
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

        static void BuscarCategorias(CategoriaService categoriaService)
        {
            Console.Clear();
            Console.WriteLine("=== Categorias Cadastradas no Sistema ===");
            List<Categoria> categoriasCadastrados = categoriaService.BuscarCategorias();
            foreach (Categoria categoria in categoriasCadastrados)
            {
                Console.WriteLine($"Id: {categoria.Id},Categoria {categoria.Nome}, Descrita como: {categoria.Descricao}");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
