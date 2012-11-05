using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using AGR.Domain.Entities;

namespace AGR.Teste.Infrasctructure
{
    [TestFixture]
    //[Ignore]
    public class CriarBancoDeDadosTest
    {
        [Test]
        public void a_Criar_Banco_De_Dados_Por_Modelo()
        {
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c
           .FromAppSetting("Conexao")
            )).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Cliente>()).Mappings(m => m.MergeMappings())
            .ExposeConfiguration(BuildSchema).BuildSessionFactory();
        }

        private void BuildSchema(Configuration config)
        {
            new SchemaExport(config)
                .Drop(true, true);

            new SchemaExport(config)
                .Create(true, true);
        }
    }
}
