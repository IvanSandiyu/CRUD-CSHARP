using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SistemaVentas
{
    [Serializable]
    class GestionVentas
    {
        
        ArrayList listaClientes = new ArrayList();
        List<Producto> listaProductos = new List<Producto>();
        public ArrayList verListaClientes { get; }

        public void AgregarCliente(ClienteCuenta unCliente)
        {
            listaClientes.Add(unCliente);
        }
        public ClienteCuenta BuscarCliente(int dni)
        {
            ClienteCuenta cl = null;
            listaClientes.Sort();
            int indice = listaClientes.BinarySearch(dni);
            if (indice != -1)
            {
                cl = (ClienteCuenta)listaClientes[indice];
            }
            return cl;

        }
        public Pedido GenerarPedido(int nro, List<Producto> lista)
        {   
            Pedido p = new Pedido(nro, lista);
            this.listaProductos = lista;
            return p;
        }
       public bool EliminarPedido(int dni,Pedido pedido)
       {
            ClienteCuenta c = BuscarCliente(dni);
            if (c != null)
            {
                c.RetirarPedido(pedido);
                return true;
            }
            else return false;
       }
    
        //public void EliminarProducto(List<Producto> listaP)
        //{
        //    foreach(Producto pro in listaP)
        //    {

        //    }
        //    listaProductos.Remove(p);
        //}
        public bool EditarPedido(int dni,Pedido pedido,List<Producto> listaNueva)
        {
            ClienteCuenta c = BuscarCliente(dni);
            bool condicion = c.EditarPedido(pedido, listaNueva);
            return condicion;
        }
        
        public bool AgregarPago(int cuit, double monto)
        {
            ClienteCuenta cliente = BuscarCliente(cuit);
            bool i = false;
            if (cliente != null)
            {
                return i = cliente.AgregarPago(monto);
            }
            else return i;
        }
        public double VerSaldo(int cuit)
        {
            ClienteCuenta cliente = BuscarCliente(cuit);
            double saldo = 0;
            if (cliente != null)
            {
                return saldo = cliente.SaldoCuenta;
            }
            else return saldo;
        }
    }
}
