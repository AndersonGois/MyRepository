using AGR.Domain.Interfaces;

namespace AGR.Domain.Entities
{
    public class Cliente : IAggregateRoot<int>
  {
      public virtual string Nome { get; set; }
      public virtual int Idade { get; set; }
      public virtual int Id { get; set; }
  }
}
