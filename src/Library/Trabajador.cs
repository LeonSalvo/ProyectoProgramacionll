using System;
using System.Collections.Generic;

namespace Chatbot
{
    public class Trabajador : IUsuario, ICalificable
    {
        public string Nombre {get;set;}
        public string Email {get;set;}
        public string Contraseña {get;set;}
        public List<double> Calificaciones {get;set;}



        public void Registrar()
        {

        }
        public void Loguear()
        {

        }
        public void Calificacion()
        {

        }
    }
}