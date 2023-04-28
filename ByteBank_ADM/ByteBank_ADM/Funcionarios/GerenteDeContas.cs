using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    { 
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }

        public override double GetBonificação()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
