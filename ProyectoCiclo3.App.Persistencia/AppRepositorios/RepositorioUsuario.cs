using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuario;
 
    public RepositorioUsuario()
        {
            usuario= new List<Usuario>()
            {
                new Usuario{Id=1,Nombre="Audi",Apellido= "Restrepo",Direccion= "Cll 40 b 56",Telefono= 2770135},
                new Usuario{Id=2,Nombre="Karoll",Apellido= "Goez",Direccion= "Cll 40 b 56",Telefono= 2770135}
            };
                
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuario;
        }
 
        public Usuario GetBusWithId(int Id){
            return usuario.SingleOrDefault(b => b.Id == Id);
        }
    }
}
