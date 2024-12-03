using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Atividades ativ = new Atividades();
            //    ativ.Resultados();

            while (true)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("[1] Somar");
                Console.WriteLine("[2] Subtrair");
                Console.WriteLine("[3] Multiplicação");
                Console.WriteLine("[4] Divisão");
                Console.WriteLine("[5] Sair");

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Somar();
                    return;
                }

            }

            Calculadora sub = new Calculadora();
            float resulSub = sub.subtrair(10, 9);
            Console.WriteLine(resulSub);

            Calculadora multi = new Calculadora();
            float resulmulti = sub.Multi(2, 9);
            Console.WriteLine(resulmulti);

            Calculadora div = new Calculadora();
            double resuldiv = sub.divisao(10, 9.7);
            Console.WriteLine(resuldiv);

            Console.ReadKey();

            void Somar()
            {
                Calculadora Calc = new Calculadora();
                float resul = Calc.Somar(resul);
                Console.WriteLine(resul);
            }
        }


    }
}
