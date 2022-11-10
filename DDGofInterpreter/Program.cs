using System.Linq.Expressions;

namespace DDGofInterpreter
{
    internal class Program
    {
        /* Interpreter
         * 
         * usado para avaliar/interpretar as instruções escritas em uma gramática de linguagem ou notações
         * 
         * montar árvore de expressões
         * expressões matemáticas
         * formatações em documentos
         * usado para DSL (Domain-Specific Language)
         * criação de compiladores
         */

        static void Main(string[] args)
        {
            // Expressão: (1 + 10) + (20 - 10)
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao resultado = new Soma(esquerda, direita);

            Console.WriteLine(resultado.Avaliar());

            //API Interpreter C#
            // Expressão: (10 + 100)
            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            Console.WriteLine(funcao());
        }
    }
}