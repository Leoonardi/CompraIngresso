using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CompraIngresso.controller
{
    internal class Ingresso
    {
        public decimal calcular(decimal valor, decimal qtd)

        { 
            decimal resul;
            resul = qtd* valor;
        return resul;

       }
    }
}
