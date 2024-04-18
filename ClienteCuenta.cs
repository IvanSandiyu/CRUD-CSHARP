using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas
{
    [Serializable]
    class ClienteCuenta:IComparable, IExportar
    {
        public string Nombre { get; set; }
        public int Cuit { get; set; }
        public double SaldoCuenta { get; set; }
        public double Tope { get; set; }
        double acumGastado;

        Queue<Pedido> listaPedidos = new Queue<Pedido>();
        public Queue<Pedido> mostrarListaPedidos { get; }

        public ClienteCuenta(string nombre, int cuit, double topeCuenta, double saldo)
        {
                SaldoCuenta = saldo;
                Nombre = nombre;
                Cuit = cuit;
                Tope = topeCuenta;
            
        }
        public double AgregarPedido(Pedido nuevoPedido)
        {
            listaPedidos.Enqueue(nuevoPedido);
            return nuevoPedido.ValorPedido(nuevoPedido);

        }
        public bool EditarPedido(Pedido pedido, List<Producto> lista)
        {
            bool x = false;
            if (listaPedidos.Contains(pedido))
            {
                foreach (Pedido p in listaPedidos)
                {
                    if (p.Nro == pedido.Nro)
                    {
                        Pedido nuevoPedido = new Pedido(pedido.Nro, lista);
                        x = true;
                    }
                }
                return x;
            }
            return x;
            
        }
        public void RetirarPedido(Pedido pedido)
        {
           pedido.EliminarPedido();
           listaPedidos.Dequeue();
        }
        public bool AgregarPago(double monto)
        {
            bool i = false;
            if (monto > 0 && monto < Tope && acumGastado <= Tope)
            {
                SaldoCuenta = SaldoCuenta - monto;
                acumGastado += monto;
                i = true;
            }
            return i;

        }
        public double EditarSaldo(double saldo)
        {
            return SaldoCuenta += saldo;
        }
        public double EditarTope(double tope)
        {
            return Tope += tope;
        }
        public string Escribir()
        {
            return Nombre + SaldoCuenta + Cuit;
        }

        public int CompareTo(object obj)
        {
            return Cuit.CompareTo(obj);
        }

        
    }
}
