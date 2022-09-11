
namespace Pav2022.P2.Presentacion.Vistas
{
    partial class RegistrarPedidoVista
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
            this.components = new System.ComponentModel.Container();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.PrecioLbl = new System.Windows.Forms.Label();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.CantidadLbl = new System.Windows.Forms.Label();
            this.CantidadTxt = new System.Windows.Forms.NumericUpDown();
            this.MontoLbl = new System.Windows.Forms.Label();
            this.MontoTxt = new System.Windows.Forms.TextBox();
            this.AgregarProductoBtn = new System.Windows.Forms.Button();
            this.ConfirmarPedidoBtn = new System.Windows.Forms.Button();
            this.PedidoLV = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bsLineaPedido = new System.Windows.Forms.BindingSource(this.components);
            this.PedidoActualDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineaPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoActualDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(3, 25);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(100, 23);
            this.CodigoTxt.TabIndex = 0;
            this.CodigoTxt.Leave += new System.EventHandler(this.CodigoTxt_Leave);
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(3, 7);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(114, 15);
            this.CodigoLbl.TabIndex = 1;
            this.CodigoLbl.Text = "Código de Producto";
            // 
            // PrecioLbl
            // 
            this.PrecioLbl.AutoSize = true;
            this.PrecioLbl.Location = new System.Drawing.Point(3, 69);
            this.PrecioLbl.Name = "PrecioLbl";
            this.PrecioLbl.Size = new System.Drawing.Size(40, 15);
            this.PrecioLbl.TabIndex = 2;
            this.PrecioLbl.Text = "Precio";
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Enabled = false;
            this.PrecioTxt.Location = new System.Drawing.Point(3, 87);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(100, 23);
            this.PrecioTxt.TabIndex = 1;
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(3, 132);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLbl.TabIndex = 4;
            this.DescripcionLbl.Text = "Descripción";
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Enabled = false;
            this.DescripcionTxt.Location = new System.Drawing.Point(3, 152);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(100, 23);
            this.DescripcionTxt.TabIndex = 2;
            // 
            // CantidadLbl
            // 
            this.CantidadLbl.AutoSize = true;
            this.CantidadLbl.Location = new System.Drawing.Point(13, 253);
            this.CantidadLbl.Name = "CantidadLbl";
            this.CantidadLbl.Size = new System.Drawing.Size(55, 15);
            this.CantidadLbl.TabIndex = 6;
            this.CantidadLbl.Text = "Cantidad";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(74, 251);
            this.CantidadTxt.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CantidadTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(82, 23);
            this.CantidadTxt.TabIndex = 3;
            this.CantidadTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadTxt.ValueChanged += new System.EventHandler(this.CantidadTxt_ValueChanged);
            // 
            // MontoLbl
            // 
            this.MontoLbl.AutoSize = true;
            this.MontoLbl.Location = new System.Drawing.Point(14, 283);
            this.MontoLbl.Name = "MontoLbl";
            this.MontoLbl.Size = new System.Drawing.Size(43, 15);
            this.MontoLbl.TabIndex = 8;
            this.MontoLbl.Text = "Monto";
            // 
            // MontoTxt
            // 
            this.MontoTxt.Enabled = false;
            this.MontoTxt.Location = new System.Drawing.Point(74, 280);
            this.MontoTxt.Name = "MontoTxt";
            this.MontoTxt.Size = new System.Drawing.Size(82, 23);
            this.MontoTxt.TabIndex = 4;
            // 
            // AgregarProductoBtn
            // 
            this.AgregarProductoBtn.Location = new System.Drawing.Point(62, 322);
            this.AgregarProductoBtn.Name = "AgregarProductoBtn";
            this.AgregarProductoBtn.Size = new System.Drawing.Size(94, 23);
            this.AgregarProductoBtn.TabIndex = 5;
            this.AgregarProductoBtn.Text = "Agregar";
            this.AgregarProductoBtn.UseVisualStyleBackColor = true;
            this.AgregarProductoBtn.Click += new System.EventHandler(this.AgregarProductoBtn_Click);
            // 
            // ConfirmarPedidoBtn
            // 
            this.ConfirmarPedidoBtn.Location = new System.Drawing.Point(532, 380);
            this.ConfirmarPedidoBtn.Name = "ConfirmarPedidoBtn";
            this.ConfirmarPedidoBtn.Size = new System.Drawing.Size(120, 23);
            this.ConfirmarPedidoBtn.TabIndex = 7;
            this.ConfirmarPedidoBtn.Text = "Confirmar Pedido";
            this.ConfirmarPedidoBtn.UseVisualStyleBackColor = true;
            this.ConfirmarPedidoBtn.Click += new System.EventHandler(this.ConfirmarPedidoBtn_Click);
            // 
            // PedidoLV
            // 
            this.PedidoLV.AutoSize = true;
            this.PedidoLV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PedidoLV.Location = new System.Drawing.Point(552, 3);
            this.PedidoLV.Name = "PedidoLV";
            this.PedidoLV.Size = new System.Drawing.Size(100, 21);
            this.PedidoLV.TabIndex = 13;
            this.PedidoLV.Text = "PedidoActual";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(62, 351);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(94, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "------>";
            // 
            // PedidoActualDGV
            // 
            this.PedidoActualDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidoActualDGV.Location = new System.Drawing.Point(225, 27);
            this.PedidoActualDGV.Name = "PedidoActualDGV";
            this.PedidoActualDGV.RowTemplate.Height = 25;
            this.PedidoActualDGV.Size = new System.Drawing.Size(427, 347);
            this.PedidoActualDGV.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CodigoTxt);
            this.panel1.Controls.Add(this.CodigoLbl);
            this.panel1.Controls.Add(this.PrecioLbl);
            this.panel1.Controls.Add(this.PrecioTxt);
            this.panel1.Controls.Add(this.DescripcionTxt);
            this.panel1.Controls.Add(this.DescripcionLbl);
            this.panel1.Location = new System.Drawing.Point(14, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 198);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccionar Producto";
            // 
            // RegistrarPedidoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PedidoActualDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.PedidoLV);
            this.Controls.Add(this.ConfirmarPedidoBtn);
            this.Controls.Add(this.AgregarProductoBtn);
            this.Controls.Add(this.MontoTxt);
            this.Controls.Add(this.MontoLbl);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.CantidadLbl);
            this.Name = "RegistrarPedidoVista";
            this.Text = "RegistrarPedidoVista";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineaPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoActualDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.Label PrecioLbl;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.Label CantidadLbl;
        private System.Windows.Forms.NumericUpDown CantidadTxt;
        private System.Windows.Forms.Label MontoLbl;
        private System.Windows.Forms.TextBox MontoTxt;
        private System.Windows.Forms.Button AgregarProductoBtn;
        private System.Windows.Forms.Button ConfirmarPedidoBtn;
        private System.Windows.Forms.Label PedidoLV;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsLineaPedido;
        private System.Windows.Forms.DataGridView PedidoActualDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}