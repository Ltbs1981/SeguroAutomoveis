using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroAutomoveis
{
    public class Seguro
    {

        public string MarcaVeiculo { get; set; }
        public string AnoVeiculo { get; set; }
        public double ValorVeiculo { get; set; }
        public double Franquia { get; set; }
        public int DuracaoEmAnos { get; set; }

        public Seguro(string marcaVeiculo, string anoVeiculo, double valorVeiculo, double franquia, int duracaoEmAnos)
        {
            MarcaVeiculo = marcaVeiculo;
            AnoVeiculo = anoVeiculo;
            ValorVeiculo = valorVeiculo;
            Franquia = franquia;
            DuracaoEmAnos = duracaoEmAnos;
        }

        public virtual double ValorSeguro() => ValorVeiculo * 0.02 + Franquia;
    }
}
