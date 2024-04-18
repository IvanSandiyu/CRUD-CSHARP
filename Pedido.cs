using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    [Serializable]
    class Pedido
    {
        public double Valor { get; set; }
        public int Nro { get; set; }
        public DateTime FechaHora { get; set; }

        public string Detalle { get; set; }
        //ArrayList listaProductos = new ArrayList();
        List<Producto> listaProductos;
        List<Pedido> listaPedidos = new List<Pedido>();

        public Pedido(int nro, List<Producto> producto)
        {
            Nro = nro;
            FechaHora = new DateTime().ToLocalTime();
            listaProductos = new List<Producto>(producto);
            listaPedidos.Add(this);
           
        }
        public double ValorPedido(Pedido pedido)
        {
            Valor = 0;
            foreach (Producto p in pedido.listaProductos )
            {
                Valor = Valor + p.Precio(p.CantidadKilos);
            }
            return Valor;
        }
        public void EliminarPedido()
        {
            listaPedidos.Remove(this);
        }
       
        
        public string VerResumen()
        {
            return "Pedido nro: " + Nro + " " + " Fecha: " + FechaHora;
        }
        public string Escribir()
        {
            return Nro + FechaHora.ToString() + Detalle + Valor;
        }
        
    }
}
