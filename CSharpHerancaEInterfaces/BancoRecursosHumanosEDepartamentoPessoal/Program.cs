

using BancoRecursosHumanosEDepartamentoPessoal.Funcionarios;
using BancoRecursosHumanosEDepartamentoPessoal.Parceria;
using BancoRecursosHumanosEDepartamentoPessoal.SistemaInterno;
using BancoRecursosHumanosEDepartamentoPessoal.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456", 2000);
//pedro.Nome = "Pedro BlaBlaBla";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("789456");
//roberta.Nome = "Roberta BlaBlaBla";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: "+gerenciador.TotalBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionario);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro:"+pedro.Salario);
//Console.WriteLine("Novo salário do Roberta:" + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer maria = new Designer("123212");
    maria.Nome = "Maria Santana";

    Diretor luciane = new Diretor("258525");
    luciane.Nome = "Luciane Marcondes";

    Auxiliar joao = new Auxiliar("486248");
    joao.Nome = "Joao Victor";

    GerenteDeContas silvana = new GerenteDeContas("789456");
    silvana.Nome = "Silvana Marcondes";

    gerenciador.Registrar(silvana);
    gerenciador.Registrar(maria);
    gerenciador.Registrar(joao);
    gerenciador.Registrar(luciane);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("123456");
    ingrid.Nome = "Ingrid Lemes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("785236");
    ursula.Nome = "Ursula Alves";
    ursula.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "666";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "452");
    sistema.Logar(caio, "666");

}