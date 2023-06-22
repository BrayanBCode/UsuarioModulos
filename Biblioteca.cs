using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using UsuariosPorModulos;

namespace UsuariosPorModulos
{
    public class Biblioteca
    {
        public ArrayList UserList;

        public Biblioteca()
        {
            this.UserList = new ArrayList();
            AddUserToUserList("Administrador", "admin", "admin");
        }

        public void MenuMain()
        {
            bool LoopMain = true;
            while (LoopMain)
            {
                System.Console.WriteLine("Menu Principal \n1 - Crear cuentas \n2 - Administrar Cuentasn \n3 - Mostrar usuarios");
                string MenuMain = Console.ReadLine().ToLower();
                switch (MenuMain)
                {
                    case "1":
                        System.Console.WriteLine("-- Cambiando de Menu --");
                        MenuCuentas();
                        break;

                    case "2":
                        System.Console.WriteLine("-- En implementacion --");
                        MenuAdministrarCuentas();
                        break;

                    case "3":
                        ShowUsers();
                        break;
                    default:
                        System.Console.WriteLine("-- Esta opcion no esta en el Menu Principal --");
                        break;
                }
            }
        }

        public void MenuAdministrarCuentas()
        {
            bool LoopMenuAdmin = true;
            do
            {
                System.Console.WriteLine("Menu Administador de cuentas \n1 - Cambiar Apodoo \n2 - Cambiar Login \n3 - Cambiar contraseña");
                string MenuAdmin = Console.ReadLine().ToLower();
                switch (MenuAdmin)
                {
                    case "1":
                        changeApodo();
                        break;

                    default:
                        System.Console.WriteLine("Esta opcion no es valida");
                        break;
                }

            } while (LoopMenuAdmin);

        }

        public void changeApodo()
        {
            bool LoopChangeApodo = true;
            do
            {
                System.Console.WriteLine("Ingrese los datos de la cuenta \nIngrese el Login de la cuenta");
                string LoginVerify = Console.ReadLine();
                System.Console.WriteLine("Ingrese la contraseña");
                string PassVerify = Console.ReadLine();

                System.Console.WriteLine(UserExist(LoginVerify, PassVerify));

            } while (LoopChangeApodo);

        }

        public bool ApodoExist(string apodo)
        {
            foreach (Usuario TUser in UserList)
            {
                if (TUser.Apodo.Equals(apodo))
                {
                    return true;
                }
            }
            return false;
        }
        public bool UserExist(string Login, string Pass)
        {
            foreach (Usuario TUser in UserList)
            {
                if (TUser.Login.Equals(Login) && TUser.Password.Equals(Pass))
                {
                    System.Console.WriteLine(TUser.Apodo);
                    return true;
                }
            }
            return false;
        }

        public void MenuCuentas()
        {
            bool LoopCuentas = true;
            do
            {
                System.Console.WriteLine("MenuCuentas de creacion de cuentas \n1 - Crear una cuenta\n2 - Crear multiples cuentas\nX - Salir");
                string MenuCuentas = Console.ReadLine().ToLower();
                switch (MenuCuentas)
                {
                    case "1":
                        CrearUser();
                        break;

                    case "2":
                        MultiCrearUser();
                        break;

                    case "3":
                        ShowUsers();
                        break;

                    case "x":
                        LoopCuentas = false;
                        break;

                    default:
                        System.Console.WriteLine("-- Esta opcion no esta en el MenuCuentas --");
                        break;
                }

            } while (LoopCuentas);

        }

        public void AddUserToUserList(string apodo, string login, string pass)
        {
            this.UserList.Add(new Usuario(apodo, login, pass));
            System.Console.WriteLine("-- Usuario ingresado --");

        }

        public void CrearUser()
        {
            System.Console.WriteLine("Ingresar un Apodo");
            string Apodo = Console.ReadLine();
            System.Console.WriteLine("Ingrese un Login");
            string login = Console.ReadLine();
            System.Console.WriteLine("Ingrese una contraseña");
            string pass = Console.ReadLine();

            AddUserToUserList(Apodo, login, pass);
        }

        public bool Xcheck(string str)
        {
            return str.ToLower().Equals("x");
        }

        public void MultiCrearUser()
        {
            bool loopMultiUser = true;
            while (loopMultiUser)
            {

                System.Console.WriteLine("Para cancelar ingrese \"X\" en uno de los campos");
                System.Console.WriteLine("Ingresar un Apodo");
                string Apodo = Console.ReadLine();
                if (Xcheck(Apodo))
                {
                    break;
                }
                System.Console.WriteLine("Ingrese un Login");
                string login = Console.ReadLine();
                if (Xcheck(login))
                {
                    break;
                }
                System.Console.WriteLine("Ingrese una contraseña");
                string pass = Console.ReadLine();
                if (Xcheck(pass))
                {
                    break;

                }
                AddUserToUserList(Apodo, login, pass);

            }

        }

        public void ShowUsers()
        {
            System.Console.WriteLine();
            foreach (Usuario TUser in UserList)
            {
                TUser.ShowUser();
            }
            System.Console.WriteLine();
        }




    }
}