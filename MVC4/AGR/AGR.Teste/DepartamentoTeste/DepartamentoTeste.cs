using AGR.Domain.Entities;
using AGR.Domain.Repository;
using AGR.Teste.BaseTest;
using NUnit.Framework;

namespace AGR.Teste.DepartamentoTeste
{
    [TestFixture]
    public class DepartamentoTeste : PersistenceTestBase
    {
        private Departamentos departamentos;
        private Departamento departamento;
        private Cliente cliente;
        private Clientes clientes;

        [SetUp]
        public void inicializar()
        {
            cliente = new Cliente();
            clientes = new Clientes(Session);
            departamentos = new Departamentos(Session);
            cliente = new Cliente { Nome = "Anderson", Idade = 36 };
            departamento = new Departamento { Nome = "Executivo" };
            departamento.Adicionar(cliente);
            departamentos.Adicionar(departamento);
        }

        [TearDown]
        public void remover_um_departamento_com_sucesso_test()
        {
            departamentos.Deletar(departamento);
        }

        [Test]
        public void alterar_departamento()
        {
            var dep = departamentos.Obter<Departamento>(departamento.Id);
            dep.Nome = "Faxina";
            departamentos.Adicionar(dep);
        }
        [Test]
        public void adicionar_um_departamento_com_sucesso_test()
        {
            Assert.AreEqual(departamento.Id, 1);
        }

        [Test]
        public void obter_o_paciente_por_id_test()
        {
            var departamentoObtido = departamentos.Obter<Departamento>(departamento.Id);

            Assert.AreEqual(departamento, departamentoObtido);
        }

        [Test]
        public void Cadastrar_clientes()
        {
            cliente.Nome = "Maria";
            clientes.Adicionar(cliente);
        }

        [Test]
        public void obter_todos_os_departamento_deve_retornar_somente_um_test()
        {
            var departamentoObtidos = departamentos.Todos<Departamento>();

            Assert.AreEqual(1, departamentoObtidos.Count);
        }

        [Test]
        public void Construtor_vasio_nao_deve_retornar_uma_excexao()
        {
            var departamentoComconstrutorvazio = new Departamentos();

            Assert.IsNotNull(departamentoComconstrutorvazio);
        }
        [Test]
        public void Construtor_de_cleentes_vasio_nao_deve_retornar_uma_excexao()
        {
            var ClientesComconstrutorvazio = new Clientes();

            Assert.IsNotNull(ClientesComconstrutorvazio);
        }

       
    }
}
