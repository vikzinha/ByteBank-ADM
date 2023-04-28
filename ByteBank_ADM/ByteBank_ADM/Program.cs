using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro";
////pedro.Cpf = "123456789";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificação());

//Diretor roberta = new Diretor("23464003272");
//roberta.Nome = "Roberta Silva";
////roberta.Cpf = "23464003272";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificação());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacoes);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

#endregion

internal class Program
{
    private static void Main(string[] args)
    {
        //CalcularBonificacao();
        void CalcularBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Designer ulisses = new Designer("9898989898");
            ulisses.Nome = "Ulisses Souza";

            Diretor paula = new Diretor("2346544432");
            paula.Nome = "Paula Souza";

            Auxiliar igor = new Auxiliar("878654578");
            igor.Nome = "Igor Dias";

            GerenteDeContas camila = new GerenteDeContas("634782");
            camila.Nome = "Camila Oliveira";

            gerenciador.Registrar(camila);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(paula);
            gerenciador.Registrar(ulisses);

            Console.WriteLine("Total de Bonificaçaõ= " + gerenciador.TotalDeBonificacoes);
        }

        UsarSistema();
        void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor ingrid = new Diretor("56567656");
            ingrid.Nome = "Ingrid Novaes";
            ingrid.Senha = "1234";

            GerenteDeContas ursula = new GerenteDeContas("93423904");
            ursula.Nome = "Úrsula Alcantara";
            ursula.Senha = "3210";

            ParceiroComercial caio = new ParceiroComercial();
            caio.Senha = "9999";
 
            sistema.Logar(ingrid, "1234");
            sistema.Logar(ursula, "9090");
            sistema.Logar(caio, "9999");
        }
    }
}