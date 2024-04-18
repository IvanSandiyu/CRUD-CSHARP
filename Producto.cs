using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    [Serializable]
    abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA ;
        public double verPrecioProducto { get; set; }
        public double CantidadKilos { get; set; }
        abstract public double Precio(double kilo);
        public override string ToString()
        {
            return Descripcion() + " " +  Precio(CantidadKilos);
        }
        abstract public string Descripcion();

        
        
    }
}
