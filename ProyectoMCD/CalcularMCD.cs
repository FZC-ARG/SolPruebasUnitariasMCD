using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMCD
{
    public class CalcularMCD
    {
        public static int MCD(int nro1,int nro2)
        {
            while(nro2 !=0)
            {
                int temporal = nro1;
                nro1 = nro2;
                nro2 = temporal % nro2;

               
            }
            return nro1;
        }
    }
}
