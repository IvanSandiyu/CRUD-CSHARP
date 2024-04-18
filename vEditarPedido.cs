using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class vEditarPedido : Form
    {
        public vEditarPedido()
        {
            InitializeComponent();
        }
        List<Producto> listaProducto = new List<Producto>();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarKG_Click(object sender, EventArgs e)
        {
            
            //double kg = Convert.ToDouble(txtKG.Text);
            //Producto producto = (Producto)listBox1.SelectedItem;
            //producto.Precio(kg);
            //listBox1.Items.Clear();

        }

        private void vEditarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
