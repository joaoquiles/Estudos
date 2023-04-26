using Projeto.Estacionamento.Modelos;
using Projeto.Estacionamento.Projeto.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Projeto.Estacionamento.Testes
{
    public class PatioTestes: IDisposable
    {
        private Veiculo veiculo;
        private Patio estacionamento;
        public ITestOutputHelper SaidaConsoleTeste;

        public PatioTestes(ITestOutputHelper _saidaConsoleTeste)
        {
            SaidaConsoleTeste = _saidaConsoleTeste;            
            veiculo = new Veiculo();
            estacionamento = new Patio();
            SaidaConsoleTeste.WriteLine("Construtor Invocado");
        }

        [Fact]
        public void ValidaFaturamentoDoEstacionamentoComUmVeiculo()
        {
            //Arrange            
            veiculo.Proprietario = "Joao";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Azul";
            veiculo.Modelo = "Mustang";
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2,faturamento);
        }

        [Theory]
        [InlineData("Joao", "ASD-1234", "preto", "Gol")]
        [InlineData("Maria", "ASD-4236", "branco", "Celta")]
        [InlineData("Vanessa", "AWQ-1234", "cinza", "EcoSport")]
        [InlineData("Joarez", "SQW-1234", "preto", "Fusca")]

        public void ValidaFaturamentoDoEstacionamentoComVariosVeiculos(string proprietario, string placa, string cor, string modelo)
        {
            //Arrange            
            veiculo.Proprietario = proprietario;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2,faturamento);
        }


        [Theory]
        [InlineData("Joao", "ASD-1234", "preto", "Gol")]
        public void LocalizaVeiculoNoPatioComBaseNaPlaca(string proprietario, string placa, string cor, string modelo) 
        {
            //Arrange            
            veiculo.Proprietario = proprietario;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;
            veiculo.Placa = placa;
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            //Act
            var consultado = estacionamento.PesquisaVeiculo(veiculo.Placa);

            //Assert
            Assert.Equal(placa,consultado.Placa);
        }

        [Fact]
        public void AlterarDadosDoProprioVeiculo()
        {
            //Arrange            
            veiculo.Proprietario = "Joao";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Azul";
            veiculo.Modelo = "Mustang";
            veiculo.Placa = "asd-9999";

            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "Joao";
            veiculoAlterado.Placa = "asd-9999";
            veiculoAlterado.Cor = "Preto"; //alterado
            veiculoAlterado.Modelo = "Mustang";

            //Act
            Veiculo alterado = estacionamento.AlterarDadosVeiculo(veiculoAlterado);

            //Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
        }

        public void Dispose()
        {     
            SaidaConsoleTeste.WriteLine("Dispose Invocado");
        }
    }
}
