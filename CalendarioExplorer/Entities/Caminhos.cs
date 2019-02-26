using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioExplorer.Entities
{
    public class Caminhos
    {
        public string Chave { get; set; }
        public string Matrizes { get; set; }
        public string MatriaisAProduzir { get; set; }
        public string CaminhoPrincipal { get; set; }
        public string CaminhoOrigem { get; set; }

        public Caminhos(string chave, string matrizes, string matriaisAProduzir, string caminhoPrincipal, string caminhoOrigem)
        {
            Chave = chave;
            Matrizes = matrizes;
            MatriaisAProduzir = matriaisAProduzir;
            CaminhoPrincipal = caminhoPrincipal;
            CaminhoOrigem = caminhoOrigem;
        }
    }
}
