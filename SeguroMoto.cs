using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAutomoveis
{
    public class SeguroMoto: Seguro
    {

        public double PremioMoto { get; set; }

        public SeguroMoto(string marcaVeiculo, string anoVeiculo, double valorVeiculo, double franquia, int duracaoEmAnos)
            : base(marcaVeiculo, anoVeiculo, valorVeiculo, franquia, duracaoEmAnos)
        {
            PremioMoto = 0.10;
        }

        public override double ValorSeguro()
        {
            return ValorVeiculo * 0.02 + Franquia + PremioMoto;
        }
    }
}
