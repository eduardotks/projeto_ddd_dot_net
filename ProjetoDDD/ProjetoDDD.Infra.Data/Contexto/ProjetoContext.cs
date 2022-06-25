using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Contexto
{
    public class ProjetoContext : DbContext
    {
        /*
        public ProjetoModeloContext()
            : base("ProjetoDDD")
        {

        }*/

        public DbSet<Cliente> Clientes { get; set; }
    }
}
