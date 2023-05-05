using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Produtos();
        void AdicionarMultiplos(params Produto[] multiples);

        
        
    }
}
