using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomienda;
 
    public RepositorioEncomienda()
        {
            encomienda= new List<Encomienda>()
            {
                new Encomienda{Id=1,Descripsion="Caja",Peso= 15},
                new Encomienda{Id=2,Descripsion="Sobre",Peso= 1},
                new Encomienda{Id=3,Descripsion="Documentos",Peso= 12}
 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomienda;
        }
 
        public Encomienda GetBusWithId(int Id){
            return encomienda.SingleOrDefault(b => b.Id == Id);
        }
    }
}
