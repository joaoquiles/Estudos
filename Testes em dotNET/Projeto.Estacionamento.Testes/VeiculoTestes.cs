using Projeto.Estacionamento.Modelos;
using Projeto.Estacionamento.Projeto.Estacionamento.Modelos;

namespace Projeto.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            //Arrange
            var veiculo = new Veiculo();
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
            var carro = new Veiculo();
            carro.Proprietario = "Joao";
            carro.Tipo = TipoVeiculo.Automovel;
            carro.Placa = "LDA-1111";
            carro.Cor = "Preto";
            carro.Modelo = "Mustang";

            //Act
            string dados = carro.ToString();

            //Assert
            Assert.Contains("Ficha do Veículo:", dados);
        }
    }
}