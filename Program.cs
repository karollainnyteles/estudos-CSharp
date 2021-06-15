using _05_ByteBank;
using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("Catch na main");
            }
           


        }
        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor= new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

                
            //}
            //catch (IOException)
            //{
               
            //    Console.WriteLine("Exceção do tipo IOException");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {

            //        leitor.Fechar();
            //    }
            //}




        }
        private static void TestaExceptions()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(41, 14222);
                ContaCorrente conta2 = new ContaCorrente(741, 47585);
                //conta1.Transferir(150, conta2);
                conta1.Sacar(300);
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Problema com o argumento: " + e.ParamName);
                Console.WriteLine("Ocorreu um erro de argumento");
                Console.WriteLine(e.Message);
            }

            catch (OperacaoFinanceiraException ex)

            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("********************");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);


            }
        }
    }
}
