using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5dn
{
    class SubtractExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public ComplexNumber Interpret(Context context)
        {
            ComplexNumber CN = new ComplexNumber();
            //z1+z2=(x1+x2)+i (y1+y2)
            CN.Re = leftExpression.Interpret(context).Re - rightExpression.Interpret(context).Re;
            CN.Im = leftExpression.Interpret(context).Im - rightExpression.Interpret(context).Im;
            return CN;
        }
    }
}
