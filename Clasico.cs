using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    [Serializable]
    class Clasico:Producto
    {
        public Clasico(string desc)
        {
            verPrecioProducto = 0;
            base.descripcion = desc;
            //base.precioBaseA = precioA;
        }
        public override double Precio(double kilo)
        {
            verPrecioProducto = kilo * 10 ;
            return verPrecioProducto;
        }
        public override string Descripcion()
        {
            return descripcion;
        }
        public override string ToString()
        {
            return Descripcion() + " " + Precio(CantidadKilos);
        }
        
    }
}
