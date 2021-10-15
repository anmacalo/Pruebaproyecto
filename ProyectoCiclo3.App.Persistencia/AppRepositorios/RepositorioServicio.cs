using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        List<Servicio> servicio;
 
    public RepositorioServicio()
        {
            servicio= new List<Servicio>()
            {
                new Servicio{Id=1,Origen=2,Destino= 3,Fecha= "15/08/2012",Hora= "14:00",Encomienda= 2014},
                new Servicio{Id=2,Origen=3,Destino= 4,Fecha= "11/08/2020",Hora= "11:00",Encomienda= 2004}
                };
                
                
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicio;
        }
 
        public Servicio GetBusWithId(int Id){
            return servicio.SingleOrDefault(b => b.Id == Id);
        }
    }
}
