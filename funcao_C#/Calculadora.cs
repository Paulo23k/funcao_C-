using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao_C_
{
    internal class Calculadora
    {
        
        public float Somar(float numero1, float numero2)
        {
            Console.WriteLine("Informe a o primeiro número: ");
            numero1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Informe a o segundo número: ");
            numero1 = float.Parse(Console.ReadLine());

            float resultado = 0;

            resultado = numero1 + numero2;

            return resultado;
        }

        public float subtrair(float numero1, float numero2)
        {
            Console.WriteLine("Informe a o primeiro número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a o segundo número: ");
            numero1 = float.Parse(Console.ReadLine());

            float resultado = 0;

            resultado = numero1 - numero2;

            return resultado;
        }

        public float Multi(float numero1, float numero2)
        {
            Console.WriteLine("Informe a o primeiro número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a o segundo número: ");
            numero1 = float.Parse(Console.ReadLine());

            float resultado = 0;

            resultado = numero1 * numero2;

            return resultado;
        }
        public double divisao(double numero1, double numero2)
        {
            Console.WriteLine("Informe a o primeiro número: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a o segundo número: ");
            numero1 = float.Parse(Console.ReadLine());

            double resultado = 0;

            resultado = numero1 / numero2;

            return resultado;
        }
    }
}
