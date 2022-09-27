using System;
using System.Collections.Generic;
using System.Text;

namespace TipoFuncionarios
{
    class Horista : Funcionario
    {
        // Propriedades
        public double SalarioHora { get; set; }
        public int QdeHorasTrabalhadas { get; set; }

        // Construtor
        public Horista()
        {
            SalarioHora = 0;
            QdeHorasTrabalhadas = 0;
        }

        //Metodos
        public override void LerDados()
        {
            string msg = "";
            try
            {
                base.LerDados();

                Console.Write("Salário Hora R$: ");
                SalarioHora = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de horas trabalhadas R$: ");
                QdeHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());

                msg = "Funcionário Horista cadastrado com sucesso! ";
            }
            catch (Exception ex)
            {
                msg = "Erro ao cadastrar Funcionário Horista " + ex;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }

        public override string MostrarDados()
        {
            return base.MostrarDados() +
                "\n Salário Hora R$: " + SalarioHora +
                "\n Quantidade de horas trabalhadas: " + QdeHorasTrabalhadas;
        }

        // Implementando o método abstrato
        public override void CalcularSalario()
        {
            base.SalarioBruto = QdeHorasTrabalhadas * SalarioHora * 4.5;
            base.CalcularINSS();
            base.CalacularIRRF();
            base.SalarioLiquido = base.SalarioBruto - base.Inss - base.Irrf;
        }
    }
}
