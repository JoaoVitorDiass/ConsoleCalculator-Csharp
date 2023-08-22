using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacoes();
        }

        static void Operacoes() {

            Console.Clear();
            Console.WriteLine("Digite a equação que deseja resolver: (nro1 + op + nro2)\n");

            var v1 = float.Parse(Console.ReadKey().KeyChar.ToString());

            var operador = Console.ReadKey().KeyChar.ToString();
            
            var v2 = float.Parse(Console.ReadKey().KeyChar.ToString());

            float resultado = 0;

            switch(operador) {
                case "+": resultado = v1 + v2; break;
                case "-": resultado = v1 - v2; break;
                case "*": resultado = v1 * v2; break;
                case "/": resultado = v1 / v2; break;
            }
            
            Console.WriteLine("\nResultado: " + resultado);
        }
    }
}