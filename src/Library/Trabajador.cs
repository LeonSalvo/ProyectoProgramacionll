using System;
using System.Collections.Generic;

namespace Chatbot
{
    public class Trabajador : IUsuario, ICalificable
    {
        public string Nombre {get;set;}
        public string Email {get;set;}
        public string Contraseña {get;set;}
        public string Telefono {get;set;}
        public string Ubicacion {get;set;}
        public List<Contrato> Calificaciones = new List<Contrato>();




        public void Registrar()
        {

        }
        public void Loguear()
        {

        }
        public void Calificar()
        {

        }
        public List<Categoria> GetCategorias()
        {

        }
        public double GetCalificacion()
        {
            
        }
        public void CrearServicio()
        {

        }
        public void QuitarSuServicio()
        {
            
        }
    }
}