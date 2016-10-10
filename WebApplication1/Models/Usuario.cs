using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usuario
    {
        private string _nombre;
        private string _apellidos;
        private string _password;
        private string _user;
        private string _email;
        private DateTime _fNacimiento;
        private Guid _codigoUsuario;

        public Usuario(string _nombre, string _apellidos, string _password, string _user, string _email, DateTime _fNacimiento, Guid _codigoUsuario)
        {
            this._nombre = _nombre;
            this._apellidos = _apellidos;
            this._password = _password;
            this._user = _user;
            this._email = _email;
            this._fNacimiento = _fNacimiento;
            this._codigoUsuario = _codigoUsuario;
        }

        public Guid CodigoUsuario
        {
            get
            {
                return _codigoUsuario;
            }

            set
            {
                _codigoUsuario = value;
            }
        }

        public DateTime FNacimiento
        {
            get
            {
                return _fNacimiento;
            }

            set
            {
                _fNacimiento = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }
    }
}