using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SGV
{
    class Viagem
    {
        String nomeViagem;
        DateTime dataInicio;
        DateTime dataFim;
        HashSet<Local> locais;

        public Viagem(String nomeViagem, DateTime dataInicio, DateTime dataFim, HashSet <Local> locais)
        {
            this.nomeViagem = nomeViagem;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.Locais = locais;
        }

        public string NomeViagem
        {
            get
            {
                return nomeViagem;
            }

            set
            {
                nomeViagem = value;
            }
        }

        public DateTime DataInicio
        {
            get
            {
                return dataInicio;
            }

            set
            {
                dataInicio = value;
            }
        }

        public DateTime DataFim
        {
            get
            {
                return dataFim;
            }

            set
            {
                dataFim = value;
            }
        }

        internal HashSet<Local> Locais
        {
            get
            {
                return locais;
            }

            set
            {
                locais = value;
            }
        }

        internal static bool validaPerido(DateTime dataIn, DateTime dataF)
        {
            if ((DateTime.Compare(DateTime.Now, dataIn) < 0) && (DateTime.Compare(dataIn, dataF) < 0))
            {
                return true;
            }
            else return false;
        }
    }
}