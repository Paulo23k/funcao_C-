using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao_C_
{
    internal class Atividades
    {
        public void Teste()
        {
            Console.WriteLine("Testeeeeeee");
        }

        public void Resultados()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma Atividade: ");
                Console.WriteLine("[1] Atividade01");
                Console.WriteLine("[2] Atividade02");
                Console.WriteLine("[3] Atividade03");
                Console.WriteLine("[4] Sair");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Atividade01();
                }
                else if (escolha == "2")
                {
                    Atividade02();
                }
                else if (escolha == "3")
                {
                    Atividade03();
                }
                if (escolha == "4")
                {
                    Console.WriteLine("Saindooooooooo...");
                    break;
                }
            }

            void Atividade01()
            {
                string aluno = "";
                float nota1 = 0;
                float nota2 = 0;
                float nota3 = 0;
                float media = 0;

                Console.Write("Informe seu nome campeão: ");
                aluno = Console.ReadLine();

                Console.Write("Informe a primeira nota: ");
                nota1 = float.Parse(Console.ReadLine());

                Console.Write("Informe a segunda nota: ");
                nota2 = float.Parse(Console.ReadLine());

                Console.Write("Informe a terceira nota: ");
                nota3 = float.Parse(Console.ReadLine());

                media = (nota1 + nota2 + nota3) / 2;

                Console.Write(aluno);
                Console.WriteLine();

                if (media >= 7)
                {
                    Console.WriteLine("Voce foi aprovado com a nota: " + media);

                }
                else if (media < 7)
                {
                    Console.WriteLine("Você foi reprovado com nota: " + media);
                }
                else
                {
                    Console.WriteLine("Valor invalido, tente novamente!!");
                }
            }

            void Atividade02()
            {
                int count = 1;
                int soma = 0;

                while (count <= 100)
                {
                    soma = count + soma;
                    Console.WriteLine(soma);
                    count++;
                }
            }

            void Atividade03()
            {
                float nota = 0.0f;

                Console.WriteLine("Informe sua nota: ");
                nota = float.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("Parabens, você está aprovado!!");
                }
                else if (nota > 5 && nota < 7)
                {
                    Console.WriteLine("Poxa, Você está de recuperação!!");

                }
                else if (nota < 5)
                {
                    Console.WriteLine("Que pena, Você foi reprovado");
                }
                else if (nota > 10)
                {
                    Console.WriteLine("Essa nota NÃO existe, tente novamente!");
                }
                else
                {
                    Console.WriteLine("Aceitamos apenas números, tente novamente!");
                }
            }
        }
    }
}
