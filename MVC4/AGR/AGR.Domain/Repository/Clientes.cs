using AGR.Domain.Entities;
using NHibernate;

namespace AGR.Domain.Repository
{
    public class Clientes : BaseRepository
    {
        public Clientes()
        {
        }
        public Clientes(ISession session)
            : base(session)
        {
        }

        public virtual void Adicionar(Cliente cliente)
        {
            base.Salvar(cliente);
        }
    }
}
