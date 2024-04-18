using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    internal class miExcepcion: ApplicationException
    {
        public miExcepcion(string mensaje) : base(mensaje)
        {
        }
        public miExcepcion(string mensaje, Exception ex) : base(mensaje, ex)
        { }
    }
}
