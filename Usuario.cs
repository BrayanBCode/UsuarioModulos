using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosPorModulos;

namespace UsuariosPorModulos
{
    public class Usuario
    {
        public string Apodo;
        public string Login;
        public string Password;
        public Usuario(string Apodo, string Login, string Password)
        {
            this.Apodo = Apodo;
            this.Login = Login;
            this.Password = Password;
        }
        public void ShowUser()
        {
                System.Console.WriteLine("-- Cuenta de " + this.Apodo + " --" + "\nLogin: " + this.Login + " - Pass: " + this.Password);
        }
    }
}