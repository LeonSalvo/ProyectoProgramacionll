using System;
using System.Collections.Generic;

namespace Chatbot
{
    public class Empleador : IUsuario, ICalificable
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
        public void GetCalificacion()
        {
            
        }
        public void ContratarServicio()
        {
            
        }
        public List<OfertaServicios> GetServicios()
        {

        }
        public List<Categoria> GetCategorias()
        {
            
        }
    }
}