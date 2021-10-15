using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Servicio { 
        public int Id{get;set;}
        public int Origen{get; set;}
        public int Destino{get; set;}
        public string Fecha { get; set;}
        public string Hora { get; set;}
        public int Encomienda {get; set;}
    }
}