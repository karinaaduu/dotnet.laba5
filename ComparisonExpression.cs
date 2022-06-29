using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5dn
{
    class ComparisonExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public ComparisonExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
        public ComplexNumber Interpret(Context context)
        {

            // |z|=sqrt (x^2+y^2)
            float absLeft = (float)Math.Sqrt(leftExpression.Interpret(context).Re * leftExpression.Interpret(context).Re +
                leftExpression.Interpret(context).Im * leftExpression.Interpret(context).Im);

            float absRight = (float)Math.Sqrt(rightExpression.Interpret(context).Re * rightExpression.Interpret(context).Re +
               rightExpression.Interpret(context).Im * rightExpression.Interpret(context).Im);

            if (absLeft < absRight)
            {
                return new ComplexNumber(rightExpression.Interpret(context).Re, rightExpression.Interpret(context).Im);
            }
            else return new ComplexNumber(leftExpression.Interpret(context).Re, leftExpression.Interpret(context).Im);
        }
    }
}
