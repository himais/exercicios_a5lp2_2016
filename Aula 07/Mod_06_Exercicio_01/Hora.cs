using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_06_Exercicio_01
{
    class Hora : Tempo
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        public Hora(DateTime dataInicial, DateTime dataFinal)
        {
            this.setDataInicial(dataInicial);
            this.setDataFinal(dataFinal);
            this.CalcularTempo();
        }

        public void setDataInicial(DateTime dataInicial)
        {
            this.dataInicial = dataInicial;
        }

        public void setDataFinal(DateTime dataFinal)
        {
            this.dataFinal = dataFinal;
        }

        public DateTime getDataInicial()
        {
            return this.dataInicial;
        }

        public DateTime getDataFinal()
        {
            return this.dataFinal;
        }


        protected override void CalcularTempo()
        {
            //Instância do TimeSpan recebendo a subtração entre as datas
            TimeSpan calculo = getDataFinal().Subtract(getDataInicial());

            //Para obter a diferença em horas
            Console.WriteLine("Diferença em horas: "+ calculo.TotalHours);
        }
    }
}