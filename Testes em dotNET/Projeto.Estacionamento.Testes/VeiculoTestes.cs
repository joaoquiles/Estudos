using Projeto.Estacionamento.Modelos;
using Projeto.Estacionamento.Projeto.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Projeto.Estacionamento.Testes
{
    public class VeiculoTestes: IDisposable
    {
        private Veiculo veiculo;
        public ITestOutputHelper SaidaConsoleTeste;

        public VeiculoTestes(ITestOutputHelper _saidaConsoleTeste)
        {
            SaidaConsoleTeste = _saidaConsoleTeste;
            SaidaConsoleTeste.WriteLine("Construtor Invocado");
            veiculo = new Veiculo();
        }

        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //Arrange
            
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            //Arrange
            
            //Act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste ainda não emplementado")]
        public void ValidaNomeProprietarioDoVeiculo()
        {

        }

        [Fact]
        public void FichaDeInformacaoDoVeiculo()
        {
            //Arrange           
            veiculo.Proprietario = "Joao";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = "LDA-1111";
            veiculo.Cor = "Preto";
            veiculo.Modelo = "Mustang";

            //Act
            string dados = veiculo.ToString();

            //Assert
            Assert.Contains("Ficha do Veículo:", dados);
        }

        public void Dispose()
        {
            SaidaConsoleTeste.WriteLine("Dispose Invocado");
        }
    }
}