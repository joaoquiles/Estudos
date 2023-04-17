using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeChavePIX
{
    /// <summary>
    /// Classe que gera chaves Pix usando o formato Guid.
    /// </summary>
    public static class GeradorPIX
    {
        
        /// <summary>
        /// Método que retorna uma chave aleatória de PIX.
        /// </summary>
        /// <returns>Retorna uma chave PIX no formato String</returns>
        public static string GetChavePIX()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves PIX.
        /// </summary>
        /// <param name="numeroChaves">Quandtidade de chaves a serem geradas</param>
        /// <returns>Lista de strings de chaves PIX</returns>
        public static List<string> GetChavesPIX(int numeroChaves)
        {
            if(numeroChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
