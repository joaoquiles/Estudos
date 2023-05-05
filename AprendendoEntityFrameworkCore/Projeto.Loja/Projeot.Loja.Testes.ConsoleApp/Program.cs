﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            GravarUsandoEntity();
            //GravarMultiplosProdutosUsandoEntity();
            RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            //AtualizarProduto();
        }

        private static void AtualizarProduto()
        {
            //incluir um produto produto
            GravarUsandoEntity();
            RecuperarProdutos();

            //atualizar o produto
            using(var repo = new ProdutoDAOEntity())
            {
                Produto produtos = repo.Produtos().First();
                produtos.Nome = "Cassino Toyale - Editado";
                repo.Atualizar(produtos);
            }
            RecuperarProdutos();

        }

        private static void ExcluirProdutos()
        {
            using(var repo = new ProdutoDAOEntity()) 
            {
                IList<Produto> produtos = repo.Produtos();
                
                foreach(var item in produtos) 
                {
                    repo.Remover(item);


                }
                
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine("Foram encontrados {0} produto(s).", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                    
                }
                
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new ProdutoDAOEntity())
            {
                contexto.Adicionar(p);
            }
        }

        private static void GravarMultiplosProdutosUsandoEntity()
        {
            Produto p1 = new Produto();
            p1.Nome = "Harry Potter e a Ordem da Fênix";
            p1.Categoria = "Livros";
            p1.Preco = 19.89;

            Produto p2 = new Produto();
            p2.Nome = "Senhor dos Anéis 1";
            p2.Categoria = "Livros";
            p2.Preco = 19.89;

            Produto p3 = new Produto();
            p3.Nome = "O Monge e o Executivo";
            p3.Categoria = "Livros";
            p3.Preco = 19.89;

            using (var contexto = new ProdutoDAOEntity())
            {
                contexto.AdicionarMultiplos(p1,p2,p3);
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
