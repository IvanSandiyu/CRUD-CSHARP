﻿namespace SistemaVentas
{
    partial class vCrearCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCrearCliente = new System.Windows.Forms.Button();
            this.txtCrearNombre = new System.Windows.Forms.TextBox();
            this.txtCrearDni = new System.Windows.Forms.TextBox();
            this.txtCrearSaldo = new System.Windows.Forms.TextBox();
            this.txtCrearTope = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCrearTope);
            this.groupBox1.Controls.Add(this.txtCrearSaldo);
            this.groupBox1.Controls.Add(this.txtCrearDni);
            this.groupBox1.Controls.Add(this.txtCrearNombre);
            this.groupBox1.Controls.Add(this.bCrearCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bCrearCliente
            // 
            this.bCrearCliente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bCrearCliente.Location = new System.Drawing.Point(93, 144);
            this.bCrearCliente.Name = "bCrearCliente";
            this.bCrearCliente.Size = new System.Drawing.Size(75, 23);
            this.bCrearCliente.TabIndex = 0;
            this.bCrearCliente.Text = "Crear";
            this.bCrearCliente.UseVisualStyleBackColor = true;
            // 
            // txtCrearNombre
            // 
            this.txtCrearNombre.Location = new System.Drawing.Point(84, 40);
            this.txtCrearNombre.Name = "txtCrearNombre";
            this.txtCrearNombre.Size = new System.Drawing.Size(100, 20);
            this.txtCrearNombre.TabIndex = 1;
            // 
            // txtCrearDni
            // 
            this.txtCrearDni.Location = new System.Drawing.Point(84, 66);
            this.txtCrearDni.Name = "txtCrearDni";
            this.txtCrearDni.Size = new System.Drawing.Size(100, 20);
            this.txtCrearDni.TabIndex = 2;
            // 
            // txtCrearSaldo
            // 
            this.txtCrearSaldo.Location = new System.Drawing.Point(84, 92);
            this.txtCrearSaldo.Name = "txtCrearSaldo";
            this.txtCrearSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtCrearSaldo.TabIndex = 3;
            // 
            // txtCrearTope
            // 
            this.txtCrearTope.Location = new System.Drawing.Point(84, 118);
            this.txtCrearTope.Name = "txtCrearTope";
            this.txtCrearTope.Size = new System.Drawing.Size(100, 20);
            this.txtCrearTope.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tope";
            // 
            // vCrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "vCrearCliente";
            this.Text = "vCrearCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtCrearNombre;
        public System.Windows.Forms.Button bCrearCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCrearTope;
        public System.Windows.Forms.TextBox txtCrearSaldo;
        public System.Windows.Forms.TextBox txtCrearDni;
    }
}