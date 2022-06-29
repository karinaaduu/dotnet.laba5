using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5dn
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            ComplexNumber number1 = new ComplexNumber(2,2);
            ComplexNumber number2 = new ComplexNumber(-3,7);

            context.SetVariable("2+2i", number1);
            context.SetVariable("-3+7i", number2);

            IExpression SumExpression = new AddExpression(new NumberExpression("2+2i"), new NumberExpression("-3+7i"));
            IExpression SubtractExpression = new SubtractExpression(new NumberExpression("2+2i"),new NumberExpression("-3+7i"));
            IExpression CompExpression = new ComparisonExpression(new NumberExpression("2+2i"), new NumberExpression("-3+7i"));
            
            ComplexNumber resultSum = SumExpression.Interpret(context);
            Console.WriteLine("Результат пiсумовування чисел {0} i {1}: {2}", number1.ToString(), number2.ToString() ,resultSum.ToString());

            ComplexNumber resultSabtr = SubtractExpression.Interpret(context);
            Console.WriteLine("Результат вiднiманнячисел {0} i {1}: {2}", number1.ToString(), number2.ToString(), resultSabtr.ToString());

            ComplexNumber resultComp = CompExpression.Interpret(context);
            Console.WriteLine("Число {0} виявилось найбiльшим.", resultComp.ToString());

            Console.Read();
        }
    } 
}
