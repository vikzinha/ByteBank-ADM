using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        // criar método que bonifica o salário
        // virtual se refere ao termo utilizado para dizer que um método
        // pode ser sobrescrito/reescrito na suas classes filhas
        public abstract double GetBonificação();
        public abstract void AumentarSalario();

        //construtor p/ sempre q criar um funcionario acontecer o 
        // incremento da variavel TotalDeFuncionarios

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf; 
            this.Salario = salario; 
            TotalDeFuncionarios++;
        }
    }
}