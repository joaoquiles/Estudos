using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeChavePIX
{
    public static class GeradorPIX
    {
        public static string GetChavePIX()
        {
            return Guid.NewGuid().ToString();
        }

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
