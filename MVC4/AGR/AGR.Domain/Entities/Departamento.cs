using System.Collections.Generic;
using AGR.Domain.Interfaces;


namespace AGR.Domain.Entities
{
    public  class Departamento : IAggregateRoot<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Cliente> Clientes { get; set; }

        public Departamento()
        {
            Clientes = new List<Cliente>();
        }

        public void Adicionar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
    }
}
