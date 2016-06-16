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
using Android.Graphics;

namespace SGV
{
    class Foto
    {
        String nome;
        Bitmap imagem;

        public Foto(String nome, Bitmap imagem)
        {
            this.nome = nome;
            this.imagem = imagem;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public Bitmap Imagem
        {
            get
            {
                return imagem;
            }

            set
            {
                imagem = value;
            }
        }
    }
}