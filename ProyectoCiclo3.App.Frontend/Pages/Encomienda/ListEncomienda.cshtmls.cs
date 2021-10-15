using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListEncomiendaModel : PageModel
       {
       
        private readonly RepositorioEncomienda repositorioencomienda;
        public IEnumerable<Encomienda> Encomienda {get;set;}
 
    public ListEncomiendaModel(RepositorioEncomienda repositorioencomienda)
    {
        this.repositorioencomienda=repositorioencomienda;
    }
        public void OnGet()
        {
            Encomienda=repositorioEncomienda.GetAll();
 
        }
    }
}
