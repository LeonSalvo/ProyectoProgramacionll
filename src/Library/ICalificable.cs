using System;
using System.Collections.Generic;

namespace Chatbot
{
    public interface ICalificable
    {
        public List<double> Calificaciones {get;set;}
        public void Calificacion();
    }
}