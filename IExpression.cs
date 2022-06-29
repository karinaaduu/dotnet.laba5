using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5dn
{
    interface IExpression
    {
        ComplexNumber Interpret(Context context);
    }
}
