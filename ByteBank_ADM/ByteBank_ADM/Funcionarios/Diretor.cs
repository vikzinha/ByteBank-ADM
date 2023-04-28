using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {

        // criar método que bonifica o salário

        //override é o termo utilizado para indicar ao compilador que
        // esse método irá reescrever o método da classe pai (Funcionario)
        public override double GetBonificação()
        {
            // base para acessar atributos e métodos da superclasse
            // se utilizar somente o metodo GetBonificação o programa entrará em 
            // stack overflow 
            return this.Salario * 0.5;
        }

        public Diretor(string cpf):base(cpf, 5000)
        {
            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
