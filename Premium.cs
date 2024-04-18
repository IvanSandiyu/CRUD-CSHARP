using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    [Serializable]
    class Premium:Producto
    {
        double precioBaseB = 0.15;

        public Premium(string descripcion)
        {
            verPrecioProducto = 0;
            base.descripcion = descripcion;
            //precioBaseB = precioB;
            //base.precioBaseA = precioA;
        }
        public override double Precio(double kilo)
        {
            verPrecioProducto =  kilo * 20;
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
