using System;
using System.Windows.Forms;

namespace Semana02Ejercicio01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.DgDetalle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CboAnios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.TextBox();
            this.LblMonto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgPedidos
            // 
            this.DgPedidos.AllowUserToAddRows = false;
            this.DgPedidos.AllowUserToDeleteRows = false;
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Location = new System.Drawing.Point(42, 92);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.ReadOnly = true;
            this.DgPedidos.Size = new System.Drawing.Size(687, 112);
            this.DgPedidos.TabIndex = 0;
            this.DgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DgPedidos.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick);
            // 
            // DgDetalle
            // 
            this.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalle.Location = new System.Drawing.Point(42, 253);
            this.DgDetalle.Name = "DgDetalle";
            this.DgDetalle.Size = new System.Drawing.Size(687, 124);
            this.DgDetalle.TabIndex = 1;
            this.DgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.DgDetalle.Layout += new System.Windows.Forms.LayoutEventHandler(this.dataGridView2_Layout);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONAR EL AÑO DEL PEDIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CboAnios
            // 
            this.CboAnios.FormattingEnabled = true;
            this.CboAnios.Location = new System.Drawing.Point(370, 21);
            this.CboAnios.Name = "CboAnios";
            this.CboAnios.Size = new System.Drawing.Size(179, 21);
            this.CboAnios.TabIndex = 3;
            this.CboAnios.SelectionChangeCommitted += new System.EventHandler(this.CboAnios_SelectionChangeCommitted_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LISTA DE PEDIDOS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "LISTA DE DETALLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto de pedidos";
            // 
            // LblNumero
            // 
            this.LblNumero.Location = new System.Drawing.Point(629, 218);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(100, 20);
            this.LblNumero.TabIndex = 8;
            // 
            // LblMonto
            // 
            this.LblMonto.Location = new System.Drawing.Point(629, 404);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(100, 20);
            this.LblMonto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboAnios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgDetalle);
            this.Controls.Add(this.DgPedidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView2_Layout(object sender, LayoutEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.DataGridView DgDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboAnios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LblNumero;
        private System.Windows.Forms.TextBox LblMonto;
    }
}

