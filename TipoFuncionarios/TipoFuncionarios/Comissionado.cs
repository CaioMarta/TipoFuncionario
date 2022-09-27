using System;
using System.Collections.Generic;
using System.Text;

namespace TipoFuncionarios
{
    class Comissionado : Funcionario
    {
        // Propriedades
        public double SalarioBase { get; set; }
        public double Comissao { get; set; }
        public double QdeServico { get; set; }

        // Construtor
        public Comissionado()
        {
            SalarioBase = 0;
            Comissao = 0;
            QdeServico = 0;
        }

        // Métodos
        public override void LerDados()
        {
            string msg = "";
            try
            {
                base.LerDados();

                Console.Write("Salário Base R$: ");
                SalarioBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Comissão R$: ");
                Comissao = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de serviços realizados R$: ");
                QdeServico = Convert.ToDouble(Console.ReadLine());

                msg = "Funcionário Comissionado cadastrado com sucesso! ";
            }
            catch(Exception ex)
            {
                msg = "Erro ao cadastrar Funcionário Comissionado " + ex;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }

        public override string MostrarDados()
        {
            return base.MostrarDados() +
                "\n Salário Base R$: " + SalarioBase +
                "\n Comissão     R$: " + Comissao +
                "\n Quantidade de serviço realizado: " + QdeServico;
        }

        // Implementando o método abstrato
        public override void CalcularSalario()
        {
            base.SalarioBruto = SalarioBase + Comissao * QdeServico;
            base.CalcularINSS();
            base.CalacularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }
    }
}
