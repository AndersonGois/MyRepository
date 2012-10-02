

using AGR.Domain.Entities;
using NHibernate;
namespace AGR.Domain.Repository
{
    public class Departamentos :BaseRepository
    {
        public Departamentos()
        {
        }
        public Departamentos(ISession session):base(session)
        {
        }

        public virtual void Adicionar(Departamento departamento)
        {
            base.Salvar(departamento);
        }
    }
}
