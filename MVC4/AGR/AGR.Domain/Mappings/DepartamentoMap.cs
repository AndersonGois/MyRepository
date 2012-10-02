using AGR.Domain.Entities;
using FluentNHibernate.Mapping;

namespace AGR.Domain.Mappings
{
   public sealed class DepartamentoMap:ClassMap<Departamento>
    {
       public DepartamentoMap()
       {
           Id(x => x.Id);
           Map(x => x.Nome);
           HasMany(x => x.Clientes).Cascade.AllDeleteOrphan();
       }

    }
}
