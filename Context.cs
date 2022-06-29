using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5dn
{
    class Context
    {
        Dictionary<string, ComplexNumber> variables;
        public Context()
        {
            variables = new Dictionary<string, ComplexNumber>();
        }
        public ComplexNumber GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, ComplexNumber value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }
}
