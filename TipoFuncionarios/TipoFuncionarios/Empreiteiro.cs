using System;
using System.Collections.Generic;
using System.Text;

namespace TipoFuncionarios
{
    class Empreiteiro : Funcionario
    {
        // Propriedades
        public double SalarioProducao { get; set; }
        public int QdeHorasTrabalhadas { get; set; }

        // Construtor
        public Empreiteiro()
        {
            SalarioProducao = 0;
            QdeHorasTrabalhadas = 0;
        }

        //Metodos
        public override void LerDados()
        {
            string msg = "";
            try
            {
                base.LerDados();

                Console.Write("Salário Produção R$: ");
                SalarioProducao = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantas horas você trabalha? ");
                QdeHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());

                msg = "Funcionário Empreiteiro cadastrado com sucesso! ";
            }
            catch (Exception ex)
            {
                msg = "Erro ao cadastrar Funcionário Empreiteiro " + ex;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }

        public override string MostrarDados()
        {
            return base.MostrarDados() +
                "\n Salário Produção R$: " + SalarioProducao +
                "\n Horas trabalhadas: " + QdeHorasTrabalhadas;
        }

        // Implementando o método abstrato
        public override void CalcularSalario()
        {
            base.SalarioBruto = QdeHorasTrabalhadas * SalarioProducao;
            base.CalcularINSS();
            base.CalacularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }
    }
}
