namespace SistemaVentas
{
    partial class vEditarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEditarKG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKG = new System.Windows.Forms.TextBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 134);
            this.listBox1.TabIndex = 0;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(73, 30);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(120, 20);
            this.txtDni.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnEditarKG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKG);
            this.groupBox1.Controls.Add(this.btnEliminarPedido);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnEliminarProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(9, 287);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 33);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnEditarKG
            // 
            this.btnEditarKG.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnEditarKG.Location = new System.Drawing.Point(189, 133);
            this.btnEditarKG.Name = "btnEditarKG";
            this.btnEditarKG.Size = new System.Drawing.Size(127, 26);
            this.btnEditarKG.TabIndex = 20;
            this.btnEditarKG.Text = "Aceptar";
            this.btnEditarKG.UseVisualStyleBackColor = true;
            this.btnEditarKG.Click += new System.EventHandler(this.btnEditarKG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Editar KG";
            // 
            // txtKG
            // 
            this.txtKG.Location = new System.Drawing.Point(219, 107);
            this.txtKG.Name = "txtKG";
            this.txtKG.Size = new System.Drawing.Size(64, 20);
            this.txtKG.TabIndex = 18;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnEliminarPedido.Location = new System.Drawing.Point(104, 231);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(87, 50);
            this.btnEliminarPedido.TabIndex = 17;
            this.btnEliminarPedido.Text = "Eliminar pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(154, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnEliminarProducto.Location = new System.Drawing.Point(9, 231);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(89, 50);
            this.btnEliminarProducto.TabIndex = 15;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(51, 56);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(120, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente DNI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vEditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "vEditarPedido";
            this.Text = "vEditarPedido";
            this.Load += new System.EventHandler(this.vEditarPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnEliminarProducto;
        public System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.Button btnEditarKG;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtKG;
    }
}