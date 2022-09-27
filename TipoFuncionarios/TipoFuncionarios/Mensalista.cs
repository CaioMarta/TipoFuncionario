using System;
using System.Collections.Generic;
using System.Text;

namespace TipoFuncionarios
{
    class Mensalista : Funcionario
    {
        public string HorarioTrabalho { get; set; }

        // Construtor
        public Mensalista()
        {
            HorarioTrabalho = null;
        }

        //Metodos
        public override void LerDados()
        {
            string msg = "";
            try
            {
                base.LerDados();

                Console.Write("Qual seu horário de trabalho: ");
                HorarioTrabalho = Console.ReadLine();

                Console.Write("Qual seu salrio bruto: ");
                SalarioBruto = Convert.ToDouble(Console.ReadLine());

                msg = "Funcionário Mensalista cadastrado com sucesso! ";
            }
            catch (Exception ex)
            {
                msg = "Erro ao cadastrar Funcionário Mensalista " + ex;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }

        public override string MostrarDados()
        {
            return base.MostrarDados() +
                "\n Horário de trabalho: " + HorarioTrabalho +
                 "\n Salario Bruto R$:" + SalarioBruto;
        }

        // Implementando o método abstrato
        public override void CalcularSalario()
        {
            SalarioBruto = SalarioBruto;
            base.CalcularINSS();
            base.CalacularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;

        }
    }
}
