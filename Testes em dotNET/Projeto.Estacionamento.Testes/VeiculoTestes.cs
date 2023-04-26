using Projeto.Estacionamento.Modelos;
using Projeto.Estacionamento.Projeto.Estacionamento.Modelos;

namespace Projeto.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact(DisplayName = "Teste de Aceleração")]
        [Trait("Funcionalidade","Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste para Frear")]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Testar nome do Proprietário", Skip = "Teste ainda não emplementado")]
        public void ValidaNomeProprietario()
        {

        }

        [Fact]
        public void DadosVeiculo()
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