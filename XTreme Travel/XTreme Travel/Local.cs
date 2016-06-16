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
    class Local
    {
        String nomeLocal;
        String morada;
        String coordenadas;
        String tipo;
        Dictionary <String, Nota> notas;
        Dictionary <String, Foto> fotos;
        HashSet <Audio> fAudio;
        HashSet <Video> videos;

        public Local(String nomeLocal, String morada, String coordenadas, String tipo)
        {
            this.nomeLocal = nomeLocal;
            this.morada = morada;
            this.coordenadas = coordenadas;
            this.tipo = tipo;
        }

        public string NomeLocal
        {
            get
            {
                return nomeLocal;
            }

            set
            {
                nomeLocal = value;
            }
        }

        public string Morada
        {
            get
            {
                return Morada;
            }

            set
            {
                Morada = value;
            }
        }

        public string Coordenadas
        {
            get
            {
                return coordenadas;
            }

            set
            {
                coordenadas = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public Dictionary<string, Nota> Notas
        {
            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }
        }

        public Dictionary<string, Foto> Fotos
        {
            get
            {
                return fotos;
            }

            set
            {
                fotos = value;
            }
        }

        internal HashSet<Audio> FAudio
        {
            get
            {
                return fAudio;
            }

            set
            {
                fAudio = value;
            }
        }

        internal HashSet<Video> Videos
        {
            get
            {
                return videos;
            }

            set
            {
                videos = value;
            }
        }
    }
}