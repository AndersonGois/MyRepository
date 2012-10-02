using AGR.Domain.Entities;
using FluentNHibernate.Mapping;

namespace AGR.Domain.Mappings
{
    public sealed class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Idade);
        }
    }
}
