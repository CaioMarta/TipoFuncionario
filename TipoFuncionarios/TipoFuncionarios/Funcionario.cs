using System;
using System.Collections.Generic;
using System.Text;

namespace TipoFuncionarios
{
    abstract class Funcionario
    {
        // Propriedades
        public string Nome { get; set; }
        public int AnoNasc { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public double Inss { get; set; }
        public double Irrf { get; set; }
        public Endereco Endereco { get; set; }

        // Construtor
        public Funcionario()
        {
            Nome = null;
            AnoNasc = 0;
            Idade = 0;
            Telefone = null;
            SalarioBruto = 0;
            SalarioLiquido = 0;
            Inss = 0;
            Irrf = 0;
            Endereco = new Endereco();
        }

        // Métodos sobrescritos (override)
        public virtual void LerDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Ano de Nascimento: ");
            AnoNasc = Convert.ToInt32(Console.ReadLine());

            // Chamar a execução do método CalcularIdade()
            CalcularIdade();

            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();

            Endereco.LerDados();
        }

        public virtual string MostrarDados()
        {
            return "\n Nome: " + Nome +
                "\n Ano de Nascimento: " + AnoNasc +
                " Idade: " + Idade + " anos" +
                "\n Telefone: " + Telefone +
                "\n Salário Bruto R$: " + SalarioBruto +
                "\n Descontos INSS R$: " + Inss +
                " IRRF R$: " + Irrf +
                "\n Salário Líquido R$: " + SalarioLiquido +
                Endereco.MostrarDados();
        }

        private void CalcularIdade()
        {
            Idade = DateTime.Now.Year - AnoNasc;
        }

        protected void CalcularINSS()
        {
            if(SalarioBruto <= 1212.00)
            {
                Inss = SalarioBruto * 0.075;
            }
            else
            {
                if(SalarioBruto > 1212.01 && SalarioBruto < 2427.35)
                {
                    Inss = SalarioBruto * 0.09;
                }
                else
                {
                    if(SalarioBruto > 2427.36 && SalarioBruto < 3641.03)
                    {
                        Inss = SalarioBruto * 0.12;
                    }
                    else
                    {
                        Inss = SalarioBruto * 0.14;
                    }
                }
            }
        }

        protected void CalacularIRRF()
        {
            if(SalarioBruto <= 1903.98)
            {
                Irrf = 0;
            }
            else
            {
                if(SalarioBruto > 1903.99 && SalarioBruto == 2826.65)
                {
                    Irrf = SalarioBruto * 0.075;
                }
                else
                {
                    if(SalarioBruto > 2826.66 && SalarioBruto == 3751.05)
                    {
                        Irrf = SalarioBruto * 0.15;
                    }
                    else
                    {
                        if(SalarioBruto > 3751.06 && SalarioBruto == 4664.68)
                        {
                            Irrf = SalarioBruto * 0.225;
                        }
                        else
                        {
                            Irrf = SalarioBruto * 0.275;
                        }
                    }
                }
            }
        }

        // Definir assinatura do método abstrato
        // Será implementado na classe concreta
        public abstract void CalcularSalario();
    }

}
