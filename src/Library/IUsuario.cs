using System;

namespace Chatbot
{
    public interface IUsuario
    {
        public string Nombre {get;set;}
        public string Email {get;set;}
        public string Contraseña {get;set;}
        public void Registrar();
        public void Loguear();
    }
}