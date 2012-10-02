using System.Collections.Generic;
using AGR.Domain.Interfaces;


namespace AGR.Domain.Entities
{
    public class Departamento : IAggregateRoot<int>
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }

        public Departamento()
        {
           Clientes = new List<Cliente>();
        }

        public virtual void Adicionar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
    }
}
