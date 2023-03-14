using BancoRecursosHumanosEDepartamentoPessoal.Funcionarios;

namespace BancoRecursosHumanosEDepartamentoPessoal.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}
