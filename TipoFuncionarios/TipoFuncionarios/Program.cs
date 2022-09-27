using System;

namespace TipoFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar classes
            Horista horista = new Horista();
            Comissionado comissionado = new Comissionado();
            Mensalista mensalista = new Mensalista();
            Empreiteiro empreiteiro = new Empreiteiro();

            int opcao = 0;

            mensalista.MostrarDados();
            // loop
            do
            {
                Console.WriteLine(" --- Opereções --- \n " +
                    "\n1 - Mensalista" +
                    "\n2 - Horista" +
                    "\n3 - Comissinado" +
                    "\n4 - Empreiteiro" +
                    "\n5 - Sair do programa" +
                    "\n ===>>> Digite sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Mensalista ");
                        mensalista.LerDados();
                        mensalista.CalcularSalario();
                        Console.WriteLine(mensalista.MostrarDados());
                        break;

                    case 2:
                        Console.WriteLine("Você escolheu Horista ");
                        horista.LerDados();
                        horista.CalcularSalario();
                        Console.WriteLine(horista.MostrarDados());
                        break;

                    case 3:
                        Console.WriteLine("\nVocê escolheu Comissionado ");
                        comissionado.LerDados();
                        comissionado.CalcularSalario();
                        Console.WriteLine(comissionado.MostrarDados());
                        
                        break;

                    case 4:
                        Console.WriteLine("Você escolheu Empreiteiro ");
                        empreiteiro.LerDados();
                        empreiteiro.CalcularSalario();
                        Console.WriteLine(empreiteiro.MostrarDados());
                        break;

                    default:
                        Console.WriteLine("Opção Inválida. Tente novamente");
                        break;

                }

            }
            while (opcao != 4);
        }
    }
}
