using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAutomoveis
{
    public class SeguroCarro: Seguro
    {

        public double PremioCarro { get; set; }

        public SeguroCarro(string marcaVeiculo, string anoVeiculo, double valorVeiculo, double franquia, int duracaoEmAnos)
            : base(marcaVeiculo, anoVeiculo, valorVeiculo, franquia, duracaoEmAnos)
        {
            PremioCarro = 0.05;
        }

        public override double ValorSeguro()
        {
            return ValorVeiculo * 0.02 + Franquia + PremioCarro;
        }
    }
}
