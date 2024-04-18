using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSaldo.Enabled = false;
            btnPagar.Enabled = false;
            groupBox2.Enabled = false;
            cbPedidos.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        GestionVentas gestion = new GestionVentas();
        ClienteCuenta cliente;
        Producto p;
        Pedido pedido;


        int n = 0;
        List<Producto> productos = new List<Producto>();


        
        private void Form1_Load(object sender, EventArgs e)
        {
            string p = Application.StartupPath;
            string nombre = Path.Combine(p, "archivo.txt");
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                if (File.Exists("archivo.txt"))
                {
                    fs = new FileStream("archivo.txt", FileMode.Open, FileAccess.Read);
                    if (fs.Length > 0)
                    {
                        bf = new BinaryFormatter();
                        gestion = (GestionVentas)bf.Deserialize(fs);
                        
                    }

                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(txtDni.Text);
                cliente = gestion.BuscarCliente(dni);

                if (cliente == null)
                {
                    vCrearCliente crearC = new vCrearCliente();
                    crearC.txtCrearDni.Text = dni.ToString();
                    bool condicion = true;
                    do
                    {
                        DialogResult result = crearC.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            if (!string.IsNullOrEmpty(crearC.txtCrearNombre.Text) && !string.IsNullOrEmpty(crearC.txtCrearSaldo.Text) && !string.IsNullOrEmpty(crearC.txtCrearTope.Text))
                            {
                                double tope = Convert.ToDouble(crearC.txtCrearTope.Text);
                                double saldo = Convert.ToDouble(crearC.txtCrearSaldo.Text);
                                if (saldo > tope || saldo <= 0 || tope <= 0)
                                {
                                    throw new miExcepcion("Por favor, el saldo/tope no puededen ser igual a 0 o saldo mayor al tope");
                                }
                                cliente = new ClienteCuenta(crearC.txtCrearNombre.Text, dni, tope, saldo);
                                gestion.AgregarCliente(cliente);
                                btnSaldo.Enabled = true;
                                btnPagar.Enabled = true;
                                groupBox2.Enabled = true;
                                condicion = false;
                            }
                            else
                            {
                                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                           
                            vCrearCliente crearCliente = new vCrearCliente(); 
                        }
                    } while (condicion);
                }
                else
                {
                    btnSaldo.Enabled = true;
                    btnPagar.Enabled = true;
                    groupBox2.Enabled = true;
                }
                
            }

            
            catch(miExcepcion ex)
            {
                vCrearCliente crearCliente = new vCrearCliente();
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                vCrearCliente crearCliente = new vCrearCliente();
                MessageBox.Show("El cliente no existe", "Error al encontrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           

        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDni.Text);
            double saldo = gestion.VerSaldo(dni);
            MessageBox.Show("El saldo disponible es de: " + saldo);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (productos != null && productos.Count > 0)
                {
                    int cuit = Convert.ToInt32(txtDni.Text);
                    double valor = pedido.ValorPedido(pedido);
                    bool g = gestion.AgregarPago(cuit, valor);
                    if (g == true)
                    {
                        MessageBox.Show("Pago realizado, su saldo actual es de: $ " + gestion.VerSaldo(cuit));
                        for (int i = 0; i < productos.Count; i++)
                        {
                            productos.RemoveAt(i);
                        }

                    }
                    else
                    {
                        throw new miExcepcion("No se pudo realizar el pago, se han superado los limites de la cuenta");
                    }
                }
                else throw new miExcepcion("No existen pedidos");

            }
            catch(miExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }

            private void btnElegir_Click(object sender, EventArgs e)
        {
           
            string nombre = cbPedidos.SelectedItem.ToString();
            if (nombre == "Clasico")
            {
                p = new Clasico("Clasico");
            }
            else
            {
                p = new Premium("Premium");
            }
            
            p.CantidadKilos = Convert.ToDouble(txtKG.Text);
            listBox1.Items.Add(p);
            productos.Add(p);
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    double acumPrecio = 0;
                    foreach (Producto prod in listBox1.Items)
                    {
                        acumPrecio += prod.verPrecioProducto;
                    }
                    int cuit = Convert.ToInt32(txtDni.Text);
                    if (cliente.Tope >= acumPrecio)
                    {
                        pedido = gestion.GenerarPedido(n++, productos);
                        double valor = cliente.AgregarPedido(pedido);
                        MessageBox.Show("Pedido agregado con exito el total es: $ " + valor);
                        listBox1.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar el pedido porque el total del pedido es mayor al tope de la cuenta");
                        listBox1.Items.Clear();
                    }


                }
                else throw new miExcepcion("No existen productos para cobrar");
                

            }
            catch(miExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string p = Application.StartupPath;
            string nombre = Path.Combine(p, "archivo.txt");
            FileStream fs = null;
            try
            {
                if (File.Exists(nombre))
                {
                    File.Delete(nombre);
                }
                BinaryFormatter bf = new BinaryFormatter();
                fs = new FileStream(nombre, FileMode.CreateNew, FileAccess.Write);
                bf.Serialize(fs, gestion);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnExportarC_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string path = Application.StartupPath;
            string nombre = Path.Combine(path, "datos.csv");
            try
            {
                saveFileDialog1.Filter = "(*.csv)|*.csv";
                if (File.Exists(nombre))
                {
                    fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Read);
                    if (fs.Length > 0)
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        pedido = (Pedido)bf.Deserialize(fs);

                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null && sw != null)
                {
                    fs.Close();
                    sw.Close();
                }
            }
        }

        private void btnExportarP_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string path = Application.StartupPath;
            string nombre = Path.Combine(path, "datos.csv");
            try
            {
                if (cliente.mostrarListaPedidos != null)
                {
                    saveFileDialog1.Filter = "(*.csv)|*.csv";
                    fs = new FileStream(nombre, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (Pedido o in cliente.mostrarListaPedidos)
                    {
                        string linea = o.Escribir();
                        sw.WriteLine(linea);
                    }
                    MessageBox.Show("Exportacion realizada con exito");
                }
                if (cliente == null) throw new miExcepcion("Hubo un problema al exportar");

            }
            catch (miExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (fs != null && sw != null)
                {
                    fs.Close();
                    sw.Close();
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FileStream fs = null; StreamReader sr = null;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea;
                    string[] campo;
                    while (sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        campo = linea.Split(';');
                        string descripcion = campo[0].Trim();
                        double precioA = Convert.ToDouble(campo[1].Trim());
                        double precioB = Convert.ToDouble(campo[2].Trim());
                        string tipo = campo[3].Trim();

                        if (tipo == "C")
                        {
                            p = new Clasico(descripcion);
                        }
                        else
                        {
                            p = new Premium(descripcion);
                        }
                        cbPedidos.Items.Add(p.ToString());
                    }

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null && sr != null)
                {
                    fs.Close();
                    sr.Close();
                }
            }
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            
            Producto eliminarProducto = (Producto)listBox1.SelectedItem;
            if (eliminarProducto != null)
            {
                productos.Remove(eliminarProducto);
                listBox1.Items.Remove(eliminarProducto);

            }
            else MessageBox.Show("No se ha seleccionado ningun producto");
           
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroP = pedido.Nro;
                Producto producto = null;
                vEditarPedido editarPedido = new vEditarPedido();
                editarPedido.groupBox1.Text = " Editar pedido - Pedido numero : " + numeroP;
                List<Producto> productosEditados = new List<Producto>();
                editarPedido.txtDni.Enabled = false;
                editarPedido.txtDni.Text = Convert.ToString(cliente.Cuit);
                editarPedido.txtCliente.Text = cliente.Nombre;
                foreach(Producto prod in productos)
                {
                    editarPedido.listBox1.Items.Add(prod);
                }

                List<Producto> listaBackup = new List<Producto>();
                List<Producto> listaBackupKG = new List<Producto>();
               
                bool condicion = true;
                
                while (condicion)
                {
                    
                    DialogResult resultado = editarPedido.ShowDialog();
                    double kgNuevo = 0;
                    
                    switch (resultado)
                    {
                        //Editar KG
                        case DialogResult.Retry:
                            producto = (Producto)editarPedido.listBox1.SelectedItem;
                            if (editarPedido.listBox1.SelectedIndex != -1)
                            {
                                kgNuevo = Convert.ToDouble(editarPedido.txtKG.Text);
                                listaBackupKG.Add(producto);
                                producto.CantidadKilos = kgNuevo;
                                editarPedido.listBox1.Items.Clear();
                                foreach (Producto p in productos)
                                {
                                    p.Precio(p.CantidadKilos);
                                    editarPedido.listBox1.Items.Add(p);
                                }
                                
                            }

                            break;

                            //Eliminar producto
                        case DialogResult.Ignore:
                            producto = (Producto)editarPedido.listBox1.SelectedItem;
                            if (producto != null)
                            {
                                MessageBox.Show(producto.ToString());
                                listaBackup.Add(producto);
                                productos.Remove(producto);
                                editarPedido.listBox1.Items.Remove(producto);

                            }
                            else MessageBox.Show("No se ha seleccionado ningun producto");
                            break;
                            //Eliminar pedido
                        case DialogResult.Yes:
                            int dni = Convert.ToInt32(editarPedido.txtDni.Text);
                            if (gestion.EliminarPedido(dni, pedido))
                            {
                                
                                MessageBox.Show("Pedido eliminado con exito!");
                                Limpiador();
                                foreach (Producto p in productos)
                                {
                                    productos.Remove(p);
                                    
                                }
                                condicion = false;
                            }
                            else MessageBox.Show("Hubo un error al eliminar el pedido");

                            break;
                        case DialogResult.Cancel:
                            if(listaBackup != null) //Verificamos si se realizo algun cambio, volvemos los cambios a valores anteriores
                            {
                                foreach(Producto p in listaBackup)
                                {
                                    productos.Add(p);
                                }
                            }
                            if(listaBackupKG != null)
                            {
                                foreach(Producto p in listaBackupKG)
                                {
                                    if (p.Equals(listaBackupKG))
                                    {
                                        productos = listaBackupKG ;
                                        
                                    }
                                }
                            }

                            condicion = false;
                            break;
                        case DialogResult.OK:
                            if(listaBackup != null) // Verificamos si hubo cambios, entonces los guardamos
                            {
                                if (gestion.EditarPedido(Convert.ToInt32(editarPedido.txtDni), pedido, listaBackup))
                                {
                                    MessageBox.Show("Pedido modificado con exito");
                                    condicion = false;
                                }
                                else MessageBox.Show("Error al modificar el pedido");
                            }
                            break;
                    }

                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Limpiador()
        {
            txtDni.Text = "";
            txtKG.Text = "";
            btnSaldo.Enabled = false;
            btnPagar.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                
                vEditarCliente editarCliente = new vEditarCliente();
                int dni = Convert.ToInt32(txtDni.Text);
                cliente = gestion.BuscarCliente(dni);
                editarCliente.txtDni.Enabled = false;
                editarCliente.txtDni.Text = dni.ToString();
                editarCliente.txtNombre.Text = cliente.Nombre;
                if (editarCliente.ShowDialog() == DialogResult.OK)
                {
                    double saldo = 0;
                    double tope = 0;
                    if(editarCliente.chbSaldo.Checked && editarCliente.chbTope.Checked)
                    {
                        saldo = Convert.ToDouble(editarCliente.txtSaldo.Text);
                        tope = Convert.ToDouble(editarCliente.txtTope.Text);
                        if (saldo < tope || saldo >= 0 || tope >= 0)
                        {
                            cliente.EditarSaldo(saldo);
                            cliente.EditarTope(tope);
                        }
                        else MessageBox.Show("El saldo no puede ser mayor al tope");
                    }
                    if(editarCliente.chbSaldo.Checked && !editarCliente.chbTope.Checked)
                    {
                        saldo = Convert.ToDouble(editarCliente.txtSaldo.Text);
                        if (saldo < cliente.Tope || saldo >= 0)
                        {
                            cliente.EditarSaldo(saldo);
                        }
                        else MessageBox.Show("El saldo excede el tope de la cuenta");
                    }
                    if (editarCliente.chbTope.Checked && !editarCliente.chbSaldo.Checked)
                    {
                        tope = Convert.ToDouble(editarCliente.txtTope.Text);
                        cliente.EditarTope(tope);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El cliente no existe", "Error al encontrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            


        }
    }
}
