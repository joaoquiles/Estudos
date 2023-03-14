using BancoRecursosHumanosEDepartamentoPessoal.SistemaInterno;

namespace BancoRecursosHumanosEDepartamentoPessoal.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
     

        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        
    }
}
