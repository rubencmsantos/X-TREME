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
    class SGVFacade
    {
        private User utilizador;
        private UserDAO userDAO;

        public SGVFacade()
        {
            this.userDAO = new UserDAO();
        }
       
        public bool login(String email, String pass)
        {
            User u = userDAO.getUser(email);
            if (u != null)
            {
                if (u.Password.Equals(pass))
                {
                    return true;
                }
            }
            return false;
        }

        public bool registar(String email, String pass, String nome, String dataNasc, String morada, String nacionalidade)
        {
            User u = userDAO.getUser(email);
            if (u == null)
            {
                DateTime dataNascimento = DateTime.Parse(dataNasc);
                userDAO.inserirUser(new User(email, pass, nome, dataNascimento, morada, nacionalidade, null));
                return true;
            }
            else return false;
        }

        public bool validarPeriodo(String dataInicio, String dataFim)
        {
            DateTime dataIn = DateTime.Parse(dataInicio);
            DateTime dataF = DateTime.Parse(dataFim);
            return Viagem.validaPerido(dataIn, dataF);
        }



    }
}