using BancoRecursosHumanosEDepartamentoPessoal.Funcionarios;
using BancoRecursosHumanosEDepartamentoPessoal.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoRecursosHumanosEDepartamentoPessoal.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false; 
            }


        }

        


    }
}
