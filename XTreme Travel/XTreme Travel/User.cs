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
    class User
    {
        String email;
        String password;
        String nome;
        String nacionalidade;
        DateTime dataNasc;
        String morada;
        Dictionary<String, Viagem> viagens;

        public User(String email, String password, String nome, DateTime dataNasc, String morada, String nacionalidade, Dictionary <String, Viagem> viagens)
        {
            this.Email = email;
            this.password = password;
            this.Nome = nome;
            this.nacionalidade = nacionalidade;
            this.dataNasc = dataNasc;
            this.morada = morada;
            this.Viagens = viagens;
        }

        

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Nacionalidade
        {
            get
            {
                return nacionalidade;
            }

            set
            {
                nacionalidade = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }

        public string Morada
        {
            get
            {
                return morada;
            }

            set
            {
                morada = value;
            }
        }

        public Dictionary<string, Viagem> Viagens
        {
            get
            {
                return viagens;
            }

            set
            {
                viagens = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
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
    }
}