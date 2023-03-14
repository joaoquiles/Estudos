using BancoRecursosHumanosEDepartamentoPessoal.SistemaInterno;

namespace BancoRecursosHumanosEDepartamentoPessoal.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}
