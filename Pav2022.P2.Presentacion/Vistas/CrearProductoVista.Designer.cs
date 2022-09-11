
namespace Pav2022.P2.Presentacion.Vistas
{
    partial class CrearProductoVista
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
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.PrecioTxt = new System.Windows.Forms.TextBox();
            this.TiempoPrepTxt = new System.Windows.Forms.TextBox();
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.PrecioLbl = new System.Windows.Forms.Label();
            this.TiempoPrepLbl = new System.Windows.Forms.Label();
            this.AgregarProdBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(614, 151);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(100, 23);
            this.CodigoTxt.TabIndex = 0;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(614, 180);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(100, 23);
            this.DescripcionTxt.TabIndex = 1;
            // 
            // PrecioTxt
            // 
            this.PrecioTxt.Location = new System.Drawing.Point(614, 209);
            this.PrecioTxt.Name = "PrecioTxt";
            this.PrecioTxt.Size = new System.Drawing.Size(100, 23);
            this.PrecioTxt.TabIndex = 2;
            // 
            // TiempoPrepTxt
            // 
            this.TiempoPrepTxt.Location = new System.Drawing.Point(614, 238);
            this.TiempoPrepTxt.Name = "TiempoPrepTxt";
            this.TiempoPrepTxt.Size = new System.Drawing.Size(100, 23);
            this.TiempoPrepTxt.TabIndex = 3;
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(562, 154);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(46, 15);
            this.CodigoLbl.TabIndex = 1;
            this.CodigoLbl.Text = "Código";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(539, 183);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLbl.TabIndex = 1;
            this.DescripcionLbl.Text = "Descripción";
            // 
            // PrecioLbl
            // 
            this.PrecioLbl.AutoSize = true;
            this.PrecioLbl.Location = new System.Drawing.Point(568, 212);
            this.PrecioLbl.Name = "PrecioLbl";
            this.PrecioLbl.Size = new System.Drawing.Size(40, 15);
            this.PrecioLbl.TabIndex = 1;
            this.PrecioLbl.Text = "Precio";
            // 
            // TiempoPrepLbl
            // 
            this.TiempoPrepLbl.AutoSize = true;
            this.TiempoPrepLbl.Location = new System.Drawing.Point(479, 241);
            this.TiempoPrepLbl.Name = "TiempoPrepLbl";
            this.TiempoPrepLbl.Size = new System.Drawing.Size(129, 15);
            this.TiempoPrepLbl.TabIndex = 1;
            this.TiempoPrepLbl.Text = "Tiempo de Preparación";
            // 
            // AgregarProdBtn
            // 
            this.AgregarProdBtn.Location = new System.Drawing.Point(639, 306);
            this.AgregarProdBtn.Name = "AgregarProdBtn";
            this.AgregarProdBtn.Size = new System.Drawing.Size(100, 23);
            this.AgregarProdBtn.TabIndex = 4;
            this.AgregarProdBtn.Text = "Agregar";
            this.AgregarProdBtn.UseVisualStyleBackColor = true;
            this.AgregarProdBtn.Click += new System.EventHandler(this.AgregarProdBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(524, 306);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(109, 23);
            this.CancelarBtn.TabIndex = 5;
            this.CancelarBtn.Text = "Salir";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(552, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crear Producto";
            // 
            // CrearProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AgregarProdBtn);
            this.Controls.Add(this.TiempoPrepLbl);
            this.Controls.Add(this.PrecioLbl);
            this.Controls.Add(this.DescripcionLbl);
            this.Controls.Add(this.CodigoLbl);
            this.Controls.Add(this.TiempoPrepTxt);
            this.Controls.Add(this.PrecioTxt);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.CodigoTxt);
            this.Name = "CrearProductoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CrearProductoVista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox PrecioTxt;
        private System.Windows.Forms.TextBox TiempoPrepTxt;
        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.Label PrecioLbl;
        private System.Windows.Forms.Label TiempoPrepLbl;
        private System.Windows.Forms.Button AgregarProdBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.Label label1;
    }
}