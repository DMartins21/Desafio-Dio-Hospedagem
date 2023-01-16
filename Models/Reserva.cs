using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;

            if(hospedes.Count > Suite.Capacidade)
            {
                Console.WriteLine("Limite de capacidade atingido, o limite total é:" + Suite.Capacidade);
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public decimal CalcularValorDiaria()
        {
            decimal Total = Suite.ValorDiaria * DiasReservados;

            if(DiasReservados >= 10)
            {
                Total = Suite.ValorDiaria * DiasReservados - (Total * 0.10M);
            }
            return Total;
        }
    }
}
