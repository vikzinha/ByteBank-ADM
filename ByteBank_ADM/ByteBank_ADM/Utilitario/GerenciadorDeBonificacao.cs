using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacoes { get; private set; }

        // criando um método que vai receber um objeto do tipo funcionario
        // ou diretor para fazer o calculo da bonificacao
        // polimorfismo > mesmo metodo vai agir de forma diferente conforme o parametro
        // As sobrecargas exigem uma lista de argumentos diferentes,
        // independentemente do nome de cada parâmetro.
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoes += funcionario.GetBonificação();
        }
    }
}
